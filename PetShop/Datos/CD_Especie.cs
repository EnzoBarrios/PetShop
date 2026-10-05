
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Entidades;

namespace PetShop.Datos
{
    public class CD_Especie
    {
        public List<Especie> Listar(string textoBusqueda = "")
        {
            List<Especie> lista = new List<Especie>();

            string query = @"SELECT id_especie, nombre_especie, estado
                                 FROM Especies
                                 WHERE (@Texto = '' OR nombre_especie LIKE @TextoLike)
                                 ORDER BY nombre_especie ASC";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;

                string filtroTexto = textoBusqueda?.Trim() ?? string.Empty;
                cmd.Parameters.Add("@Texto", SqlDbType.VarChar, 50).Value = filtroTexto;
                cmd.Parameters.Add("@TextoLike", SqlDbType.VarChar, 52).Value = "%" + filtroTexto + "%";

                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(MapearEspecie(dr));
                    }
                }
            }

            return lista;
        }

        public int Registrar(Especie especie)
        {
            string query = @"INSERT INTO Especies (nombre_especie, estado)
                                 VALUES (@NombreEspecie, @Estado)
                                 SELECT SCOPE_IDENTITY();";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@NombreEspecie", SqlDbType.VarChar, 50).Value = especie.NombreEspecie;
                cmd.Parameters.AddWithValue("@Estado", SqlDbType.Bit).Value = especie.Estado;

                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private Especie MapearEspecie(SqlDataReader dr)
        {
            int ordId = dr.GetOrdinal("id_usuario");
            int ordNombre = dr.GetOrdinal("nombre_especie");
            int ordEstado = dr.GetOrdinal("estado");

            return new Especie()
            {
                IdEspecie = dr.GetInt32(ordId),
                NombreEspecie = dr.GetString(ordNombre),
                Estado = dr.GetBoolean(ordEstado)
            };
        }
    }
}

                    
