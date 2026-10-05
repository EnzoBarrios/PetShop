using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PetShop.Entidades;

namespace PetShop.Datos
{
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            string query = @"SELECT id_rol, nombre_rol 
                             FROM Rol 
                             ORDER BY nombre_rol ASC";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(MapearRol(dr));
                    }
                }
            }
            
            return lista;
        }

        private static Rol MapearRol(SqlDataReader dr)
        {
            int ordId = dr.GetOrdinal("id_rol");
            int ordNombre = dr.GetOrdinal("nombre_rol");

            return new Rol
            {
                IdRol = dr.GetInt32(ordId),
                NombreRol = dr.GetString(ordNombre)
            };
        }
    }
}
