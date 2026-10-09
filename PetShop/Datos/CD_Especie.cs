
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

            string query = @"
                SELECT id_especie, nombre_especie, estado
                FROM Especie
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

        public Especie ObtenerPorId(int idEspecie)
        {
            string query = @"
                SELECT id_especie, nombre_especie, estado
                FROM Especie 
                WHERE id_especie = @IdEspecie";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdEspecie", SqlDbType.Int).Value = idEspecie;

                conexion.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return MapearEspecie(dr);
                    }
                }
            }

            return null;
        }

        public bool ExisteNombre(string nombreEspecie)
        {
            const string query = @"
                SELECT COUNT(1) 
                FROM Especie 
                WHERE LOWER(TRIM(nombre_especie)) = LOWER(TRIM(@Nombre));";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombreEspecie.Trim();

                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public int Registrar(Especie especie)
        {
            string query = @"
                INSERT INTO Especie (nombre_especie, estado)
                VALUES (@Nombre, @Estado);
                SELECT SCOPE_IDENTITY();";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = especie.Nombre;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = especie.Estado;

                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool Modificar(Especie especie)
        {
            const string query = @"
                UPDATE Especie 
                SET nombre_especie = @Nombre, estado = @Estado 
                WHERE id_especie = @Id;";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = especie.Nombre.Trim();
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = especie.Estado;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = especie.IdEspecie;

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CambiarEstado(int idEspecie, bool nuevoEstado)
        {
            string query = @"
                UPDATE Especie  
                SET estado = @Estado 
                WHERE id_especie = @IdEspecie";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdEspecie", SqlDbType.Int).Value = idEspecie;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = nuevoEstado;

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private Especie MapearEspecie(SqlDataReader dr)
        {
            int ordId = dr.GetOrdinal("id_especie");
            int ordNombre = dr.GetOrdinal("nombre_especie");
            int ordEstado = dr.GetOrdinal("estado");

            return new Especie()
            {
                IdEspecie = dr.GetInt32(ordId),
                Nombre = dr.GetString(ordNombre),
                Estado = dr.GetBoolean(ordEstado)
            };
        }
    }
}
