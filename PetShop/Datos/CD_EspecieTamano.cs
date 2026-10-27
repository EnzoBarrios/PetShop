using PetShop.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PetShop.Datos
{
    public class CD_EspecieTamano
    {
        public List<EspecieTamano> Listar()
        {
            var lista = new List<EspecieTamano>();

            string query = @"
                SELECT et.id_especie, e.nombre_especie AS nombre_especie, e.estado AS estado_especie,
                       et.id_tamano, t.nombre_tamano AS nombre_tamano, t.estado AS estado_tamano
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
            estadoActual = true; // Si existe el registro en la tabla intermedia, la combinación está activa
            string query = @"
                SELECT COUNT(1)
                FROM Especie_Tamano 
                WHERE id_especie = @IdEspecie AND id_tamano = @IdTamano;";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdEspecie", SqlDbType.Int).Value = idEspecie;
                cmd.Parameters.Add("@IdTamano", SqlDbType.Int).Value = idTamano;

                conexion.Open();
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                return cantidad > 0;
            }
        }

        public bool Registrar(EspecieTamano relacion)
        {
            string query = @"
                INSERT INTO Especie_Tamano (id_especie, id_tamano)
                VALUES (@IdEspecie, @IdTamano);";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdEspecie", SqlDbType.Int).Value = relacion.IdEspecie;
                cmd.Parameters.Add("@IdTamano", SqlDbType.Int).Value = relacion.IdTamano;

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CambiarEstado(int idEspecie, int idTamano, bool nuevoEstado)
        {
            // Al no existir una columna estado en la tabla intermedia, esta función retorna true si existe la tupla
            return ExisteRelacion(idEspecie, idTamano, out _);
        }

        private static EspecieTamano MapearEspecieTamano(SqlDataReader dr)
        {
            int ordIdEsp = dr.GetOrdinal("id_especie");
            int ordNomEsp = dr.GetOrdinal("nombre_especie");
            int ordEstEsp = dr.GetOrdinal("estado_especie");

            int ordIdTam = dr.GetOrdinal("id_tamano");
            int ordNomTam = dr.GetOrdinal("nombre_tamano");
            int ordEstTam = dr.GetOrdinal("estado_tamano");

            bool estadoEspecie = dr.GetBoolean(ordEstEsp);
            bool estadoTamano = dr.GetBoolean(ordEstTam);

            return new EspecieTamano()
            {
                IdEspecie = dr.GetInt32(ordIdEsp),
                IdTamano = dr.GetInt32(ordIdTam),
                // La combinación está activa solo si AMBOS componentes están activos
                Estado = estadoEspecie && estadoTamano,
                Especie = new Especie
                {
                    IdEspecie = dr.GetInt32(ordIdEsp),
                    Nombre = dr.GetString(ordNomEsp),
                    Estado = estadoEspecie
                },
                Tamano = new Tamano
                {
                    IdTamano = dr.GetInt32(ordIdTam),
                    Nombre = dr.GetString(ordNomTam),
                    Estado = estadoTamano
                }
            };
        }
    }
}