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
    public class CD_Categoria
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            string query = @"
                SELECT id_categoria, nombre_categoria, descripcion, estado
                FROM Categoria 
                ORDER BY nombre_categoria ASC";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                conexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(MapearCategoria(dr));
                    }
                }
            }
            
            return lista;
        }

        public Categoria ObtenerPorId(int idCategoria)
        {
            string query = @"
                SELECT id_categoria, nombre_categoria, descripcion, estado
                FROM Categoria 
                WHERE id_categoria = @IdCategoria";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = idCategoria;

                conexion.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return MapearCategoria(dr);
                    }
                }
            }
            return null;
        }

        public int Registrar(Categoria categoria)
        {
            string query = @"
                INSERT INTO Categoria (nombre_categoria, descripcion, estado)
                VALUES (@NombreCategoria, @Descripcion, @Estado);
                SELECT SCOPE_IDENTITY();";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@NombreCategoria", SqlDbType.VarChar, 50).Value = categoria.NombreCategoria.Trim();
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = categoria.Estado ? 1 : 0;

                // Manejar el valor nulo para la descripción
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255).Value = 
                    string.IsNullOrWhiteSpace(categoria.Descripcion) ? (object)DBNull.Value : categoria.Descripcion.Trim();

                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool Modificar(Categoria categoria)
        {
            string query = @"
                UPDATE Categoria
                SET nombre_categoria = @NombreCategoria, descripcion = @Descripcion
                WHERE id_categoria = @IdCategoria";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
                
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = categoria.IdCategoria;
                cmd.Parameters.Add("@NombreCategoria", SqlDbType.VarChar, 50).Value = categoria.NombreCategoria.Trim();

                // Manejar el valor nulo para la descripción
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255).Value =
                    string.IsNullOrEmpty(categoria.Descripcion) ? (object)DBNull.Value : categoria.Descripcion.Trim();

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CambiarEstado(int idCategoria, bool nuevoEstado)
        {
            string query = @"
                UPDATE Categoria  
                SET estado = @Estado 
                WHERE id_categoria = @IdCategoria";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
                
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = idCategoria;
                cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = nuevoEstado;

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ExisteNombre(string nombreCategoria, int idCategoriaActual = 0)
        {
            string query = @"
                SELECT COUNT(1) 
                FROM Categoria 
                WHERE LOWER(nombre_categoria) = LOWER(@NombreCategoria) 
                AND (id_categoria <> @IdCategoria OR @IdCategoria = 0)";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@NombreCategoria", SqlDbType.VarChar, 50).Value = nombreCategoria.Trim();
                cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = idCategoriaActual;

                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private static Categoria MapearCategoria(SqlDataReader dr)
        {
            int ordId = dr.GetOrdinal("id_categoria");
            int ordNombre = dr.GetOrdinal("nombre_categoria");
            int ordDescrip = dr.GetOrdinal("descripcion");
            int ordEstado = dr.GetOrdinal("estado");

            return new Categoria()
            {
                IdCategoria = dr.GetInt32(ordId),
                NombreCategoria = dr.GetString(ordNombre),
                Descripcion = dr.IsDBNull(ordDescrip) ? null : dr.GetString(ordDescrip),
                Estado = dr.GetBoolean(ordEstado)
            };
        }
    }
}
