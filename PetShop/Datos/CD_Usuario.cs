using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PetShop.Entidades;
using System.Windows.Forms;

namespace PetShop.Datos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    String query = "SELECT u.id_usuario, u.nombre, u.apellido, u.nombre_usuario, u.clave, u.dni, " +
                        "u.correo, u.telefono, u.fecha_creacion, u.estado, r.id_rol, r.nombre_rol " +
                        "FROM Usuario u INNER JOIN Rol r ON u.id_rol = r.id_rol";

                    SqlCommand cmd = new SqlCommand(query, conexion)
                    {
                        CommandType = CommandType.Text
                    };

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
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
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar la base de datos: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lista = new List<Usuario>();
                }
                return lista;
            }
        }
    }
}
