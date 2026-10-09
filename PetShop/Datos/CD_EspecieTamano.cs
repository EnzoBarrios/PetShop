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
    public class CD_EspecieTamano
    {
        public List<EspecieTamano> Listar()
        {
            var lista = new List<EspecieTamano>();

            string query = @"
                SELECT et.id_especie, e.nombre_especie AS nombre_especie, e.estado AS estado_especie,
                       et.id_tamano, t.nombre_tamano AS nombre_tamano, t.estado AS estado_tamano,
                       et.estado
                FROM Especie_Tamano et
                INNER JOIN Especie e ON (et.id_especie = e.id_especie)
                INNER JOIN Tamano t ON (et.id_tamano = t.id_tamano)
                ORDER BY e.nombre_especie ASC, t.nombre_tamano ASC;";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion)) 
            {
                cmd.CommandType = CommandType.Text;
                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(MapearEspecieTamano(dr));
                    }
                }
            }

            return lista;
        }

        public bool ExisteRelacion(int idEspecie, int idTamano, out bool estadoActual)
        {
            estadoActual = false;
            string query = @"
                SELECT estado
                FROM Especie_Tamano 
                WHERE id_especie = @IdEspecie AND id_tamano = @IdTamano;";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdEspecie", SqlDbType.Int).Value = idEspecie;
                cmd.Parameters.Add("@IdTamano", SqlDbType.Int).Value = idTamano;

                conexion.Open();
                object resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    estadoActual = Convert.ToBoolean(resultado);
                    return true;
                }

                return false;
            }
        }

        public bool Registrar(EspecieTamano relacion)
        {
            string query = @"
                INSERT INTO Especie_Tamano (id_especie, id_tamano, estado)
                VALUES (@IdEspecie, @IdTamano, @Estado);";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdEspecie", SqlDbType.Int).Value = relacion.IdEspecie;
                cmd.Parameters.Add("@IdTamano", SqlDbType.Int).Value = relacion.IdTamano;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = relacion.Estado;

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CambiarEstado(int idEspecie, int idTamano, bool nuevoEstado)
        {
            string query = @"
                UPDATE Especie_Tamano 
                SET estado = @Estado 
                WHERE id_especie = @IdEspecie AND id_tamano = @IdTamano;";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = nuevoEstado;
                cmd.Parameters.Add("@IdEspecie", SqlDbType.Int).Value = idEspecie;
                cmd.Parameters.Add("@IdTamano", SqlDbType.Int).Value = idTamano;

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private static EspecieTamano MapearEspecieTamano(SqlDataReader dr)
        {
            int ordIdEsp = dr.GetOrdinal("id_especie");
            int ordNomEsp = dr.GetOrdinal("nombre_especie");
            int ordEstEsp = dr.GetOrdinal("estado_especie");

            int ordIdTam = dr.GetOrdinal("id_tamano");
            int ordNomTam = dr.GetOrdinal("nombre_tamano");
            int ordEstTam = dr.GetOrdinal("estado_tamano");

            int ordEstado = dr.GetOrdinal("estado");

            return new EspecieTamano()
            {
                IdEspecie = dr.GetInt32(ordIdEsp),
                IdTamano = dr.GetInt32(ordIdTam),
                Estado = dr.GetBoolean(ordEstado),
                Especie = new Especie
                {
                    IdEspecie = dr.GetInt32(ordIdEsp),
                    Nombre = dr.GetString(ordNomEsp),
                    Estado = dr.GetBoolean(ordEstEsp)
                },
                Tamano = new Tamano
                {
                    IdTamano = dr.GetInt32(ordIdTam),
                    Nombre = dr.GetString(ordNomTam),
                    Estado = dr.GetBoolean(ordEstTam)
                }
            };
        }
    }
}
