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
    public class CD_Tamano
    {
        public List<Tamano> Listar(string textoBusqueda = "")
        {
            List<Tamano> lista = new List<Tamano>();

            string query = @"
                SELECT id_tamano, nombre_tamano, estado
                FROM Tamano
                WHERE (@Texto = '' OR nombre_tamano LIKE @TextoLike)
                ORDER BY nombre_tamano ASC";

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
                        lista.Add(MapearTamano(dr));
                    }
                }
            }

            return lista;
        }

        public Tamano ObtenerPorId(int idTamano)
        {
            string query = @"
                SELECT id_tamano, nombre_tamano, estado
                FROM Tamano 
                WHERE id_especie = @IdTamano";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdTamano", SqlDbType.Int).Value = idTamano;

                conexion.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return MapearTamano(dr);
                    }
                }
            }

            return null;
        }

        public bool ExisteNombre(string nombreTamano)
        {
            const string query = @"
                SELECT COUNT(1) 
                FROM Tamano 
                WHERE LOWER(TRIM(nombre_tamano)) = LOWER(TRIM(@Nombre));";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombreTamano.Trim();

                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public int Registrar(Tamano tamano)
        {
            string query = @"
                INSERT INTO Tamano (nombre_tamano, estado)
                VALUES (@Nombre, @Estado);
                SELECT SCOPE_IDENTITY();";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = tamano.Nombre;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = tamano.Estado;

                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool Modificar(Tamano tamano)
        {
            const string query = @"
                UPDATE Tamano 
                SET nombre_tamano = @Nombre, estado = @Estado 
                WHERE id_tamano = @Id;";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = tamano.Nombre.Trim();
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = tamano.Estado;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = tamano.IdTamano;

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CambiarEstado(int idTamano, bool nuevoEstado)
        {
            string query = @"
                UPDATE Tamano  
                SET estado = @Estado 
                WHERE id_tamano = @IdTamano";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdTamano", SqlDbType.Int).Value = idTamano;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = nuevoEstado;

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private Tamano MapearTamano(SqlDataReader dr)
        {
            int ordId = dr.GetOrdinal("id_tamano");
            int ordNombre = dr.GetOrdinal("nombre_tamano");
            int ordEstado = dr.GetOrdinal("estado");

            return new Tamano()
            {
                IdTamano = dr.GetInt32(ordId),
                Nombre = dr.GetString(ordNombre),
                Estado = dr.GetBoolean(ordEstado)
            };
        }
    }
}
