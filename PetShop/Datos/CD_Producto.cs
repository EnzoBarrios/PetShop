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
    public class CD_Producto
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            string query = @"SELECT p.id_producto, p.codigo_barra, p.nombre_producto, p.descripcion, p.precio_compra, p.precio_venta,
                                        p.stock_actual, p.stock_minimo, p.estado, p.fecha_creacion
                                FROM Producto p
                                INNER JOIN Categoria c ON (p.id_categoria = c.id_categoria)
                                LEFT JOIN Especie_Tamano et ON (p.id_especie = et.id_especie AND p.id_tamano = et.id_tamano)
                                LEFT JOIN Especie e ON (et.id_especie = e.id_especie)
                                LEFT JOIN Tamano t ON (et.id_tamano = t.id_tamano)
                                ORDER BY p.nombre_producto ASC";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                conexion.Open();
                    
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(MapearProducto(dr));
                    }
                }
            }

            return lista;
        }

        public int Resgistrar(Producto obj, out string mensaje)
        {
            int idProductoGenerado = 0;
            mensaje = string.Empty;

            string query = @"INSERT INTO Producto ( codigo_barra, nombre_producto, descripcion, precio_compra, precio_venta, 
                                                        stock_actual, stock_minimo, id_categoria, id_especie, id_tamano) 
                                VALUES (@CodigoBarra, @NombreProducto, @Descripcion, @PrecioCompra, @PrecioVenta, @StockActual, 
                                        @StockMinimo, @IdCategoria, @IdEspecie, @IdTamano); 
                                SELECT SCOPE_IDENTITY();";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
                
                
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                CargarParametrosProducto(cmd, obj);

                try
                {
                    conexion.Open();
                    idProductoGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idProductoGenerado = 0;
                    mensaje = "Error en la BD al registrar el producto: " + ex.Message;
                }
            }

            return idProductoGenerado;
        }

        public bool Modificar(Producto obj, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            string query = @"UPDATE Producto 
                                SET codigo_barra = @CodigoBarra, nombre_producto = @NombreProducto, descripcion = @Descripcion, 
                                    precio_compra = @PrecioCompra, precio_venta = @PrecioVenta, stock_actual = @StockActual, 
                                    stock_minimo = @StockMinimo, id_categoria = @IdCategoria, id_especie = @IdEspecie, id_tamano = @IdTamano
                                WHERE id_producto = @IdProducto";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
                

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdProducto", obj.IdProducto);
                CargarParametrosProducto(cmd, obj);

                try
                {
                    conexion.Open();
                    resultado = cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    resultado = false;
                    mensaje = "Error en la BD al modificar el producto: " + ex.Message;
                }
            }

            return resultado;
        }

        public bool CambiarEstado(int idProducto, bool nuevoEstado)
        {
            string query = @"UPDATE Producto 
                                SET estado = @NuevoEstado 
                                WHERE id_producto = @IdProducto";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
                

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                cmd.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);

                try
                {
                    conexion.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cambiar el estado del producto.", ex);
                }
            }
        }

        public bool ExisteCodigoBarra(string codigoBarra)
        {
            string query = @"SELECT COUNT(1) 
                                 FROM Producto 
                                 WHERE LOWER(codigo_barra) = LOWER(@CodigoBarra)";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
                

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CodigoBarra", codigoBarra);
                                        
                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    
            }
        }

        public bool ExisteCodigoBarraParaOtro(string codigoBarra, int idProductoActual)
        {
            string query = @"SELECT COUNT(1) 
                                 FROM Producto 
                                 WHERE LOWER(codigo_barra) = LOWER(@CodigoBarra) 
                                    AND id_producto <> @IdProducto";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CodigoBarra", codigoBarra.Trim());
                cmd.Parameters.AddWithValue("@IdProducto", idProductoActual);
                    
                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public Producto ObtenerProductoPorCodigo(string codigoBarra)
        {
            Producto producto = null;

            string query = @"SELECT p.id_producto, p.codigo_barra, p.nombre_producto, p.descripcion, p.precio_compra, p.precio_venta,
                                        p.stock_actual, p.stock_minimo, p.estado, p.fecha_creacion,
                                        c.id_categoria, c.nombre_categoria,
                                        et.id_especie, et.id_tamano,
                                        e.nombre_especie,
                                        t.nombre_tamano
                                FROM Producto p
                                INNER JOIN Categoria c ON (p.id_categoria = c.id_categoria)
                                LEFT JOIN Especie_Tamano et ON (p.id_especie = et.id_especie AND p.id_tamano = et.id_tamano)
                                LEFT JOIN Especie e ON (et.id_especie = e.id_especie)
                                LEFT JOIN Tamano t ON (et.id_tamano = t.id_tamano)
                                WHERE LOWER(p.codigo_barra) = LOWER(@CodigoBarra)";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CodigoBarra", codigoBarra.Trim());

                conexion.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        producto = MapearProducto(dr);
                    }
                }
                
            }

            return producto;
        }

        public static void CargarParametrosProducto(SqlCommand cmd, Producto obj)
        {
            cmd.Parameters.AddWithValue("@CodigoBarra", obj.CodigoBarra.Trim());
            cmd.Parameters.AddWithValue("@NombreProducto", obj.NombreProducto.Trim());
            cmd.Parameters.AddWithValue("@PrecioCompra", obj.PrecioCompra);
            cmd.Parameters.AddWithValue("@PrecioVenta", obj.PrecioVenta);
            cmd.Parameters.AddWithValue("@StockActual", obj.StockActual);
            cmd.Parameters.AddWithValue("@StockMinimo", obj.StockMinimo);
            cmd.Parameters.AddWithValue("@Estado", obj.Estado ? 1 : 0);
            cmd.Parameters.AddWithValue("@Categoria", obj.Categoria);

            // Manejo de nulos para descripción
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255).Value = 
                string.IsNullOrWhiteSpace(obj.Descripcion) ? (object)DBNull.Value : obj.Descripcion.Trim();

            // Manejo de nulos para IdEspecie y IdTamano respetando la consistencia (ambos o ninguno)
            if (obj.IdEspecie.HasValue && obj.IdTamano.HasValue && obj.IdEspecie.Value > 0 && obj.IdTamano.Value > 0)
            {
                cmd.Parameters.AddWithValue("@IdEspecie", obj.IdEspecie.Value);
                cmd.Parameters.AddWithValue("@IdTamano", obj.IdTamano.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@IdEspecie", DBNull.Value);
                cmd.Parameters.AddWithValue("@IdTamano", DBNull.Value);
            }
        }

        private Producto MapearProducto(SqlDataReader dr)
        {

            Producto producto = new Producto
            {
                IdProducto = Convert.ToInt32(dr["id_producto"]),
                CodigoBarra = dr["codigo_barra"].ToString(),
                NombreProducto = dr["nombre_producto"].ToString(),
                Descripcion = dr["descripcion"].ToString(),
                PrecioCompra = Convert.ToDecimal(dr["precio_compra"]),
                PrecioVenta = Convert.ToDecimal(dr["precio_venta"]),
                StockActual = Convert.ToInt32(dr["stock_actual"]),
                StockMinimo = Convert.ToInt32(dr["stock_minimo"]),
                Estado = Convert.ToBoolean(dr["estado"]),
                FechaCreacion = Convert.ToDateTime(dr["fecha_creacion"]),
                IdCategoria = Convert.ToInt32(dr["id_categoria"]),
                Categoria = new Categoria
                {
                    IdCategoria = Convert.ToInt32(dr["id_categoria"]),
                    NombreCategoria = dr["nombre_categoria"].ToString()
                },
            };

            if (dr["id_especie"] != DBNull.Value && dr["id_tamano"] != DBNull.Value)
            {
                int idEspecie = Convert.ToInt32(dr["id_especie"]);
                int idTamano = Convert.ToInt32(dr["id_tamano"]);

                producto.IdEspecie = Convert.ToInt32(dr["id_especie"]);
                producto.IdTamano = Convert.ToInt32(dr["id_tamano"]);
                producto.EspecieTamano = new EspecieTamano
                {
                    IdEspecie = idEspecie,
                    IdTamano = idTamano,
                    Especie = new Especie
                    {
                        IdEspecie = idEspecie,
                        NombreEspecie = dr["nombre_especie"].ToString()
                    },
                    Tamano = new Tamano
                    {
                        IdTamano = idTamano,
                        NombreTamano = dr["nombre_tamano"].ToString()
                    }
                };
            }
            else
            {
                producto.IdEspecie = null;
                producto.IdTamano = null;
                producto.EspecieTamano = null;
            }
            return producto;
        }
    }
}
