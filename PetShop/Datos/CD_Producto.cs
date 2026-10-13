using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PetShop.Entidades;

namespace PetShop.Datos
{
    public class CD_Producto
    {
        public List<Producto> Listar(string textoBusqueda = "")
        {
            List<Producto> lista = new List<Producto>();

            string query = @"
                SELECT p.id_producto, p.codigo_barra, p.nombre_producto, p.descripcion, 
                       p.precio_compra, p.precio_venta, p.stock_actual, p.stock_minimo, 
                       p.estado, p.fecha_creacion,
                       c.id_categoria, c.nombre_categoria, 
                       c.descripcion AS descrip_categoria, 
                       c.estado AS estado_categoria,
                       ISNULL(et.id_especie, 0) AS id_especie, 
                       ISNULL(et.id_tamano, 0) AS id_tamano,
                       ISNULL(et.estado, 0) AS estado_et,
                       ISNULL(e.nombre_especie, '') AS nombre_especie,
                       ISNULL(t.nombre_tamano, '') AS nombre_tamano
                FROM Producto p
                INNER JOIN Categoria c ON (p.id_categoria = c.id_categoria)
                LEFT JOIN Especie_Tamano et ON (p.id_especie = et.id_especie AND p.id_tamano = et.id_tamano)
                LEFT JOIN Especie e ON (et.id_especie = e.id_especie)
                LEFT JOIN Tamano t ON (et.id_tamano = t.id_tamano)
                WHERE (@Texto = '' OR (
                        p.nombre_producto  LIKE @TextoLike OR 
                        p.descripcion      LIKE @TextoLike OR
                        c.nombre_categoria LIKE @TextoLike))
                ORDER BY p.nombre_producto ASC";

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
                        lista.Add(MapearProducto(dr));
                    }
                }
            }

            return lista;
        }

        public Producto ObtenerPorId(int idProducto)
        {
            string query = @"
                SELECT p.id_producto, p.codigo_barra, p.nombre_producto, p.descripcion, 
                       p.precio_compra, p.precio_venta, p.stock_actual, p.stock_minimo, 
                       p.estado, p.fecha_creacion,
                       c.id_categoria, c.nombre_categoria, 
                       c.descripcion AS descrip_categoria, 
                       c.estado AS estado_categoria,
                       ISNULL(et.id_especie, 0) AS id_especie, 
                       ISNULL(et.id_tamano, 0) AS id_tamano,
                       ISNULL(et.estado, 0) AS estado_et,
                       ISNULL(e.nombre_especie, '') AS nombre_especie,
                       ISNULL(t.nombre_tamano, '') AS nombre_tamano
                FROM Producto p
                INNER JOIN Categoria c ON (p.id_categoria = c.id_categoria)
                LEFT JOIN Especie_Tamano et ON (p.id_especie = et.id_especie AND p.id_tamano = et.id_tamano)
                LEFT JOIN Especie e ON (et.id_especie = e.id_especie)
                LEFT JOIN Tamano t ON (et.id_tamano = t.id_tamano)
                WHERE p.id_producto = @IdProducto";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Value = idProducto;

                conexion.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return MapearProducto(dr);
                    }
                }
            }
            return null;
        }

        public int Registrar(Producto producto)
        {
            int idProductoGenerado = 0;

            string query = @"
                INSERT INTO Producto (
                    codigo_barra, nombre_producto, descripcion, precio_compra, precio_venta, 
                    stock_actual, stock_minimo, id_categoria, id_especie, id_tamano) 
                VALUES (
                    @Codigo, @Nombre, @Descripcion, @PrecioCompra, @PrecioVenta, 
                    @StockActual, @StockMinimo, @IdCategoria, @IdEspecie, @IdTamano); 
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                CargarParametrosProducto(cmd, producto);

                conexion.Open();
                idProductoGenerado = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return idProductoGenerado;
        }

        public bool Modificar(Producto producto)
        {
            string query = @"
                UPDATE Producto 
                SET codigo_barra    = @Codigo,     
                    nombre_producto = @Nombre, 
                    descripcion     = @Descripcion, 
                    precio_compra   = @PrecioCompra, 
                    precio_venta    = @PrecioVenta, 
                    stock_actual    = @StockActual, 
                    stock_minimo    = @StockMinimo, 
                    id_categoria    = @IdCategoria, 
                    id_especie      = @IdEspecie, 
                    id_tamano       = @IdTamano
                WHERE id_producto = @IdProducto";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Value = producto.IdProducto;
                CargarParametrosProducto(cmd, producto);

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CambiarEstado(int idProducto, bool nuevoEstado)
        {
            string query = @"
                UPDATE Producto 
                SET estado = @NuevoEstado 
                WHERE id_producto = @IdProducto";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            { 
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Value = idProducto;
                cmd.Parameters.Add("@NuevoEstado", SqlDbType.Bit).Value = nuevoEstado;

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ExisteCodigoBarra(string codigoBarra, int idProductoActual = 0)
        {
            string query = @"
                SELECT COUNT(1) 
                FROM Producto 
                WHERE LOWER(codigo_barra) = LOWER(@CodigoBarra)
                    AND (@IdProducto = 0 OR id_producto <> @IdProducto)";

            using (SqlConnection conexion = ConexionBd.CrearConexion())

            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.Add("@CodigoBarra", SqlDbType.VarChar, 50).Value = codigoBarra.Trim();
                cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Value = idProductoActual;

                conexion.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public static void CargarParametrosProducto(SqlCommand cmd, Producto producto)
        {
            cmd.Parameters.Add("@Codigo", SqlDbType.VarChar, 50).Value = producto.Codigo.Trim();
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = producto.Nombre.Trim();
            cmd.Parameters.Add("@PrecioCompra", SqlDbType.Decimal).Value = producto.PrecioCompra;
            cmd.Parameters.Add("@PrecioVenta", SqlDbType.Decimal).Value = producto.PrecioVenta;
            cmd.Parameters.Add("@StockActual", SqlDbType.Int).Value = producto.StockActual;
            cmd.Parameters.Add("@StockMinimo", SqlDbType.Int).Value = producto.StockMinimo;
            cmd.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = producto.Categoria.IdCategoria;

            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255).Value =
                string.IsNullOrWhiteSpace(producto.Descripcion) ? (object)DBNull.Value : producto.Descripcion.Trim();

            // Manejo de nulos para IdEspecie y IdTamano respetando la consistencia (ambos o ninguno)
            if (producto.EspecieTamano != null &&
                producto.EspecieTamano.IdEspecie > 0 &&
                producto.EspecieTamano.IdTamano > 0)
            {
                cmd.Parameters.Add("@IdEspecie", SqlDbType.Int).Value = producto.EspecieTamano.IdEspecie;
                cmd.Parameters.Add("@IdTamano", SqlDbType.Int).Value = producto.EspecieTamano.IdTamano;
            }
            else
            {
                cmd.Parameters.Add("@IdEspecie", SqlDbType.Int).Value = DBNull.Value;
                cmd.Parameters.Add("@IdTamano", SqlDbType.Int).Value = DBNull.Value;
            }
        }

        private Producto MapearProducto(SqlDataReader dr)
        {
            int ordIdProducto = dr.GetOrdinal("id_producto");
            int ordCodigo = dr.GetOrdinal("codigo_barra");
            int ordNombreProducto = dr.GetOrdinal("nombre_producto");
            int ordDescripcionProducto = dr.GetOrdinal("descripcion");
            int ordPrecioCompra = dr.GetOrdinal("precio_compra");
            int ordPrecioVenta = dr.GetOrdinal("precio_venta");
            int ordStockActual = dr.GetOrdinal("stock_actual");
            int ordStockminimo = dr.GetOrdinal("stock_minimo");
            int ordEstadoProducto = dr.GetOrdinal("estado");
            int ordFecha = dr.GetOrdinal("fecha_creacion");

            int ordIdCategoria = dr.GetOrdinal("id_categoria");
            int ordNombreCategoria = dr.GetOrdinal("nombre_categoria");
            int ordDescripcionCategoria = dr.GetOrdinal("descrip_categoria");
            int ordEstadoCategoria = dr.GetOrdinal("estado_categoria");

            int ordIdEspecie = dr.GetOrdinal("id_especie");
            int ordIdTamano = dr.GetOrdinal("id_tamano");
            int ordEstadoEspecieTamano = dr.GetOrdinal("estado_et");
            int ordNombreEspecie = dr.GetOrdinal("nombre_especie");
            int ordNombreTamano = dr.GetOrdinal("nombre_tamano");

            Producto producto = new Producto()
            {
                IdProducto = dr.GetInt32(ordIdProducto),
                Codigo = dr.GetString(ordCodigo),
                Nombre = dr.GetString(ordNombreProducto),
                Descripcion = dr.IsDBNull(ordDescripcionProducto) ? string.Empty : dr.GetString(ordDescripcionProducto),
                PrecioCompra = dr.GetDecimal(ordPrecioCompra),
                PrecioVenta = dr.GetDecimal(ordPrecioVenta),
                StockActual = dr.GetInt32(ordStockActual),
                StockMinimo = dr.GetInt32(ordStockminimo),
                Estado = dr.GetBoolean(ordEstadoProducto),
                FechaCreacion = dr.GetDateTime(ordFecha),

                Categoria = new Categoria
                {
                    IdCategoria = dr.GetInt32(ordIdCategoria),
                    NombreCategoria = dr.GetString(ordNombreCategoria),
                    Descripcion = dr.IsDBNull(ordDescripcionCategoria) ? string.Empty : dr.GetString(ordDescripcionCategoria),
                    Estado = dr.GetBoolean(ordEstadoCategoria),
                }
            };

            int idEspecie = dr.GetInt32(ordIdEspecie);
            int idTamano = dr.GetInt32(ordIdTamano);

            if (idEspecie > 0 && idTamano > 0)
            {
                producto.EspecieTamano = new EspecieTamano
                {
                    IdEspecie = idEspecie,
                    IdTamano = idTamano,
                    Estado = dr.GetBoolean(ordEstadoEspecieTamano),
                    Especie = new Especie { IdEspecie = idEspecie, Nombre = dr.GetString(ordNombreEspecie) },
                    Tamano = new Tamano { IdTamano = idTamano, Nombre = dr.GetString(ordNombreTamano) }
                };
            }

            return producto;
        }
    }
}
