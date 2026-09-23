using PetShop.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Datos
{
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection conexion = new SqlConnection(Conexion.CadenaConexion))
            {
                string query = $@"SELECT id_rol, nombre_rol 
                                  FROM Rol 
                                  ORDER BY nombre_rol ASC";

                SqlCommand cmd = new SqlCommand(query, conexion)
                {
                    CommandType = CommandType.Text
                };

                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Rol
                        {
                            IdRol = Convert.ToInt32(dr["id_rol"]),
                            NombreRol = dr["nombre_rol"].ToString()
                        });
                    }
                }
            }
            return lista;
        }
    }
}
