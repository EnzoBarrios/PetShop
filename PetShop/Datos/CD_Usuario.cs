using PetShop.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace PetShop.Datos
{
    public class CD_Usuario
    {
        // Método para listar todos los usuarios junto con su rol
        public List<Usuario> Listar(int idRolFiltro = 0, string textoBusqueda = "")
        {
            List<Usuario> lista = new List<Usuario>();

            string query = @"SELECT u.id_usuario, u.nombre, u.apellido, u.nombre_usuario, u.clave, 
                                    u.dni, u.correo, u.telefono, u.fecha_creacion, u.estado, 
                                    ISNULL(r.id_rol, 0) AS id_rol, ISNULL(r.nombre_rol, 'Sin Rol') AS nombre_rol
                             FROM Usuario u 
                             LEFT JOIN Rol r ON (u.id_rol = r.id_rol)
                             WHERE (@IdRol = 0 OR u.id_rol = @IdRol)
                               AND (@Texto = '' OR (u.nombre LIKE @TextoLike
                                                          OR u.apellido LIKE @TextoLike
                                                          OR u.nombre_usuario LIKE @TextoLike))
                             ORDER BY u.apellido ASC, u.nombre ASC";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;

                string filtroTexto = textoBusqueda?.Trim() ?? string.Empty;
                cmd.Parameters.Add("@IdRol", SqlDbType.Int).Value = idRolFiltro;
                cmd.Parameters.Add("@Texto", SqlDbType.VarChar, 50).Value = filtroTexto;
                cmd.Parameters.Add("@TextoLike", SqlDbType.VarChar, 52).Value = "%" + filtroTexto + "%";

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

        // Método para obtener un usuario por su ID
        public Usuario ObtenerPorId(int idUsuario)
        {
            string query = @"SELECT u.id_usuario, u.nombre, u.apellido, u.nombre_usuario, u.clave, 
                                    u.dni, u.correo, u.telefono, u.estado, u.fecha_creacion, 
                                    r.id_rol, r.nombre_rol
                             FROM Usuario u
                             INNER JOIN Rol r ON (u.id_rol = r.id_rol)
                             WHERE u.id_usuario = @IdUsuario";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idUsuario;

                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return MapearUsuario(dr);
                    }
                }
            }

            return null;
        }

        public Usuario ObtenerPorNombreUsuario(string nombreUsuario)
        {
            string query = @"SELECT u.id_usuario, u.nombre, u.apellido, u.nombre_usuario, u.clave, 
                                    u.dni, u.correo, u.telefono, u.estado, u.fecha_creacion, 
                                    ISNULL(r.id_rol, 0) AS id_rol, ISNULL(r.nombre_rol, 'Sin Rol') AS nombre_rol
                             FROM Usuario u
                             INNER JOIN Rol r ON (u.id_rol = r.id_rol)
                             WHERE LOWER(u.nombre_usuario) = LOWER(@NombreUsuario)";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 50).Value = nombreUsuario.Trim();
                conexion.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return MapearUsuario(dr);
                    }
                }
            }

            return null;
        }

        // Método para registrar un nuevo usuario en la base de datos
        public int Registrar(Usuario usuario)
        {
            string query = @"INSERT INTO Usuario 
                                (nombre, apellido, nombre_usuario, clave, dni, correo, telefono, estado, fecha_creacion, id_rol) 
                            VALUES 
                                (@Nombre, @Apellido, @Usuario, @Clave, @Dni, @Correo, @Telefono, @Estado, GETDATE(), @IdRol)
                            SELECT SCOPE_IDENTITY()";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;

                CargarParametrosUsuario(cmd, usuario);
                cmd.Parameters.Add("@Clave", SqlDbType.VarChar, 255).Value = usuario.Clave;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = usuario.Estado;
                cmd.Parameters.Add("IdRol", SqlDbType.Int).Value = usuario.Rol.IdRol;

                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Método para editar un usuario existente, con opción de actualizar la clave
        public bool Modificar(Usuario usuario, bool actualizarClave = false)
        {
            string query = @"UPDATE Usuario 
                             SET nombre = @Nombre, 
                                 apellido = @Apellido, 
                                 nombre_usuario = @NombreUsuario, 
                                 dni = @Dni, 
                                 correo = @Correo, 
                                 telefono = @Telefono, 
                                 id_rol = @IdRol, 
                                 estado = @Estado"
                             + (actualizarClave ? ", clave = @Clave " : " ") +
                             "WHERE id_usuario = @IdUsuario;";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;

                CargarParametrosUsuario(cmd, usuario);
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = usuario.IdUsuario;
                cmd.Parameters.Add("@IdRol", SqlDbType.Int).Value = usuario.Rol.IdRol;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = usuario.Estado;

                if (actualizarClave)
                {
                    cmd.Parameters.Add("@Clave", SqlDbType.VarChar, 255).Value = usuario.Clave;
                }

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }     
        }

        public bool ActualizarHashClave(int idUsuario, string nuevoHash)
        {
            const string query = @"UPDATE Usuario 
                                   SET clave = @Clave 
                                   WHERE id_usuario = @IdUsuario;";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@Clave", SqlDbType.VarChar, 255).Value = nuevoHash;
                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idUsuario;

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Método para cambiar el estado de un usuario (activo/inactivo)
        public bool CambiarEstado(int idUsuario, bool nuevoEstado)
        {
            string query = @"UPDATE Usuario 
                             SET estado = @Estado 
                             WHERE id_usuario = @IdUsuario";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
                
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idUsuario;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = nuevoEstado;

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Métodos para verificar la existencia de un usuario, DNI o correo en la base de datos
        public bool ExisteUsuario(string nombreUsuario, int idUsuarioActual = 0)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                return false;
            }

            return ExisteCampo("nombre_usuario", nombreUsuario.Trim(), idUsuarioActual);
        }

        // Método para verificar si un DNI ya existe en la base de datos
        public bool ExisteDni(string dni, int idUsuarioActual = 0)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                return false;
            }

            return ExisteCampo("dni", dni.Trim(), idUsuarioActual);
        }

        // Método para verificar si un correo electrónico ya existe en la base de datos
        public bool ExisteCorreo(string correo, int idUsuarioActual = 0)
        {
            if (string.IsNullOrWhiteSpace(correo))
            {
                return false;
            }

            return ExisteCampo("correo", correo.Trim(), idUsuarioActual);
        }

        private bool ExisteCampo(string nombreCampo, string valorCampo, int idUsuarioActual = 0)
        {
            var camposValidos = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "nombre_usuario", "dni", "correo"
            };

            if (!camposValidos.Contains(nombreCampo))
            {
                throw new ArgumentException($"El campo '{nombreCampo}' no está permitido para validación de unicidad.");
            }

            string query = $@"SELECT COUNT(1) 
                              FROM Usuario 
                              WHERE LOWER({nombreCampo}) = LOWER(@ValorCampo) 
                              AND (id_usuario <> @IdActual OR @IdActual = 0)";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ValorCampo", SqlDbType.VarChar, 100).Value = valorCampo;
                cmd.Parameters.Add("@IdActual", SqlDbType.Int).Value = idUsuarioActual;

                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private static void CargarParametrosUsuario(SqlCommand cmd, Usuario usuario)
        {
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre.Trim();
            cmd.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido.Trim();
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario.Trim();
            
            cmd.Parameters.Add("@Dni", SqlDbType.VarChar, 20).Value =
                string.IsNullOrWhiteSpace(usuario.Dni) ? (object)DBNull.Value : usuario.Dni.Trim();
            cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value =
                string.IsNullOrWhiteSpace(usuario.Correo) ? (object)DBNull.Value : usuario.Correo.Trim();
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 20).Value =
                string.IsNullOrWhiteSpace(usuario.Telefono) ? (object)DBNull.Value : usuario.Telefono.Trim();
        }

        // Método privado para mapear los datos de un SqlDataReader a un objeto Usuario
        private Usuario MapearUsuario(SqlDataReader dr)
        {
            int ordId = dr.GetOrdinal("id_usuario");
            int ordNombre = dr.GetOrdinal("nombre");
            int ordApellido = dr.GetOrdinal("apellido");
            int ordNombreUsuario = dr.GetOrdinal("nombre_usuario");
            int ordClave = dr.GetOrdinal("clave");
            int ordDni = dr.GetOrdinal("dni");
            int ordCorreo = dr.GetOrdinal("correo");
            int ordTelefono = dr.GetOrdinal("telefono");
            int ordFechaCreacion = dr.GetOrdinal("fecha_creacion");
            int ordEstado = dr.GetOrdinal("estado");
            int ordIdRol = dr.GetOrdinal("id_rol");
            int ordNombreRol = dr.GetOrdinal("nombre_rol");

            return new Usuario()
            {
                IdUsuario = dr.GetInt32(ordId),
                Nombre  = dr.GetString(ordNombre),
                Apellido = dr.GetString(ordApellido),
                NombreUsuario = dr.GetString(ordNombreUsuario),
                Clave = dr.GetString(ordClave),
                Dni = dr.IsDBNull(ordDni) ? null : dr.GetString(ordDni),
                Correo = dr.IsDBNull(ordCorreo) ? null : dr.GetString(ordCorreo),
                Telefono = dr.IsDBNull(ordTelefono) ? null : dr.GetString(ordTelefono),
                FechaCreacion = dr.GetDateTime(ordFechaCreacion),
                Estado = dr.GetBoolean(ordEstado),
                Rol = new Rol()
                {
                    IdRol = dr.GetInt32(ordIdRol),
                    NombreRol = dr.GetString(ordNombreRol)
                }
            };
        }
    }
}
