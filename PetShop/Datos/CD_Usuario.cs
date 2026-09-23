using PetShop.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Datos
{
    public class CD_Usuario
    {
        // Método para listar todos los usuarios junto con su rol
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                string query = $@"SELECT u.id_usuario, u.nombre, u.apellido, u.nombre_usuario, u.clave, u.dni,
                                        u.correo, u.telefono, u.fecha_creacion, u.estado, r.id_rol, r.nombre_rol
                                FROM Usuario u 
                                INNER JOIN Rol r ON (u.id_rol = r.id_rol)";

                SqlCommand cmd = new SqlCommand(query, conexion)
                {
                    CommandType = CommandType.Text
                };

                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(MapearUsuario(dr));
                    }
                }
            }
            return lista;
        }

        // Método para listar usuarios filtrados por rol y texto de búsqueda
        public List<Usuario> ListarFiltrado(string condicionRolSql, string textoBusqueda)
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                string query = $@"SELECT u.id_usuario, u.nombre, u.apellido, u.nombre_usuario, u.clave, u.dni,
                                        u.correo, u.telefono, u.fecha_creacion, u.estado, r.id_rol, r.nombre_rol
                                FROM Usuario u 
                                INNER JOIN Rol r ON (u.id_rol = r.id_rol)
                                WHERE {condicionRolSql}
                                AND (u.nombre LIKE @texto 
                                     OR u.apellido LIKE @texto 
                                     OR u.nombre_usuario LIKE @texto)";

                SqlCommand cmd = new SqlCommand(query, conexion)
                {
                    CommandType = CommandType.Text
                };

                cmd.Parameters.AddWithValue("@texto", "%" + (textoBusqueda?? "") + "%");
                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(MapearUsuario(dr));
                    }
                }
            }
            return lista;
        }

        // Método para cambiar el estado de un usuario (activo/inactivo)
        public bool CambiarEstado(int idUsuario, bool nuevoEstado)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                string query = $@"UPDATE Usuario 
                                SET estado = @Estado 
                                WHERE id_usuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conexion)
                {
                    CommandType = CommandType.Text
                };

                cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                conexion.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Los métodos de agregar, actualizar y eliminar usuarios se implementarían aquí, siguiendo un patrón similar al método Listar.
        private Usuario MapearUsuario(SqlDataReader dr)
        {
            return new Usuario()
            {
                IdUsuario = Convert.ToInt32(dr["id_usuario"]),
                Nombre = dr["nombre"].ToString(),
                Apellido = dr["apellido"].ToString(),
                NombreUsuario = dr["nombre_usuario"].ToString(),
                Clave = dr["clave"].ToString(),
                Dni = dr["dni"].ToString(),
                Correo = dr["correo"].ToString(),
                Telefono = dr["telefono"].ToString(),
                FechaCreacion = Convert.ToDateTime(dr["fecha_creacion"]),
                Estado = Convert.ToBoolean(dr["estado"]),
                IdRol = Convert.ToInt32(dr["id_rol"]),
                Rol = new Rol()
                {
                    IdRol = Convert.ToInt32(dr["id_rol"]),
                    NombreRol = dr["nombre_rol"].ToString()
                }
            };
        }

        // Métodos para verificar la existencia de un usuario, DNI o correo en la base de datos
        public bool ExisteUsuario(string nombreUsuario)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                string query = $@"SELECT COUNT(1) 
                                  FROM Usuario 
                                  WHERE LOWER(nombre_usuario) = LOWER(@Usuario)";
                SqlCommand cmd = new SqlCommand(query, conexion)
                {
                    CommandType = CommandType.Text
                };

                cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);
                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // Método para verificar si un DNI ya existe en la base de datos
        public bool ExisteDni(string dni)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                string query = $@"SELECT COUNT(1) 
                                  FROM Usuario 
                                  WHERE dni = @Dni";
                SqlCommand cmd = new SqlCommand(query, conexion)
                {
                    CommandType = CommandType.Text
                };

                cmd.Parameters.AddWithValue("@Dni", dni);
                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // Método para verificar si un correo electrónico ya existe en la base de datos
        public bool ExisteCorreo(string correo)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                string query = $@"SELECT COUNT(1) 
                                  FROM Usuario 
                                  WHERE LOWER(correo) = LOWER(@Correo)";
                SqlCommand cmd = new SqlCommand(query, conexion)
                {
                    CommandType = CommandType.Text
                };

                cmd.Parameters.AddWithValue("@Correo", correo);
                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // Método para registrar un nuevo usuario en la base de datos
        public bool Registrar(Usuario obj)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                string query = $@"INSERT INTO Usuario (nombre, apellido, nombre_usuario, clave, dni, correo, telefono, estado, fecha_creacion, id_rol) 
                                  VALUES (@Nombre, @Apellido, @Usuario, @Clave, @Dni, @Correo, @Telefono, 1, GETDATE(), @IdRol)";

                SqlCommand cmd = new SqlCommand(query, conexion)
                {
                    CommandType = CommandType.Text
                };

                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre.Trim());
                cmd.Parameters.AddWithValue("@Apellido", obj.Apellido.Trim());
                cmd.Parameters.AddWithValue("@Usuario", obj.NombreUsuario.Trim());
                cmd.Parameters.AddWithValue("@Clave", obj.Clave.Trim());
                cmd.Parameters.AddWithValue("@IdRol", obj.IdRol);

                cmd.Parameters.Add("@Dni", SqlDbType.VarChar).Value = string.IsNullOrWhiteSpace(obj.Dni) ? (object)DBNull.Value : obj.Dni.Trim();
                cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = string.IsNullOrWhiteSpace(obj.Correo) ? (object)DBNull.Value : obj.Correo.Trim();
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = string.IsNullOrWhiteSpace(obj.Telefono) ? (object)DBNull.Value : obj.Telefono.Trim();

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Método para obtener un usuario por su ID
        public Usuario ObtenerPorId(int idUsuario)
        {
            Usuario usuario = null;

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                string query = $@"SELECT id_usuario, nombre, apellido, nombre_usuario, clave, dni, 
                                correo, telefono, id_rol, estado, fecha_creacion
                                FROM Usuario 
                                WHERE id_usuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conexion)
                {
                    CommandType = CommandType.Text
                };

                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        usuario = new Usuario
                        {
                            IdUsuario = Convert.ToInt32(dr["id_usuario"]),
                            Nombre = dr["nombre"].ToString(),
                            Apellido = dr["apellido"].ToString(),
                            NombreUsuario = dr["nombre_usuario"].ToString(),
                            Clave = dr["clave"].ToString(),
                            Dni = dr["dni"] != DBNull.Value ? dr["dni"].ToString() : "",
                            Correo = dr["correo"] != DBNull.Value ? dr["correo"].ToString() : "",
                            Telefono = dr["telefono"] != DBNull.Value ? dr["telefono"].ToString() : "",
                            IdRol = Convert.ToInt32(dr["id_rol"]),
                            Estado = Convert.ToBoolean(dr["estado"]),
                            FechaCreacion = Convert.ToDateTime(dr["fecha_creacion"])
                        };
                    }
                }
            }

            return usuario;
        }

        // Método para verificar si un nombre de usuario ya existe para otro usuario distinto al actual
        public bool ExisteNombreUsuarioParaOtro(string nombreUsuario, int idUsuarioActual)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                string query = $@"SELECT COUNT(1) 
                                  FROM Usuario 
                                  WHERE LOWER(nombre_usuario) = LOWER(@Usuario) 
                                  AND id_usuario <> @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conexion)
                {
                    CommandType = CommandType.Text
                };

                cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuarioActual);
                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // Método para editar un usuario existente, con opción de actualizar la clave
        public bool EditarUsuario(Usuario obj, bool actualizarClave)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                string query = @"UPDATE Usuario 
                                SET nombre = @Nombre, 
                                    apellido = @Apellido, 
                                    nombre_usuario = @Usuario, 
                                    id_rol = @IdRol, 
                                    estado = @Estado";

                if (actualizarClave)
                {
                    query += ", clave = @Clave";
                }

                query += " WHERE id_usuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conexion)
                {
                    CommandType = CommandType.Text
                };

                cmd.Parameters.AddWithValue("@Nombre", obj.Nombre.Trim());
                cmd.Parameters.AddWithValue("@Apellido", obj.Apellido.Trim());
                cmd.Parameters.AddWithValue("@Usuario", obj.NombreUsuario.Trim());
                cmd.Parameters.AddWithValue("@IdRol", obj.IdRol);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);
                cmd.Parameters.AddWithValue("@IdUsuario", obj.IdUsuario);

                if (actualizarClave)
                {
                    cmd.Parameters.AddWithValue("@Clave", obj.Clave.Trim());
                }

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
