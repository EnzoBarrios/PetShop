using System;
using System.Data;
using System.Data.SqlClient;
using PetShop.Entidades;

namespace PetShop.Datos
{
    public class CD_Reporte
    {
        public DataTable ObtenerStockCritico()
        {
            DataTable dataTable = new DataTable();

            string query = @"
                SELECT 
                    p.id_producto AS [ID Producto], 
                    p.codigo_barra AS [Codigo Barra], 
                    p.nombre_producto AS [Producto], 
                    c.nombre_categoria AS [Categoria], 
                    ISNULL(e.nombre_especie, 'N/A') AS [Especie], 
                    ISNULL(t.nombre_tamano, 'N/A') AS [Tamaño],
                    p.stock_actual AS [Stock Actual], 
                    p.stock_minimo AS [Stock Minimo]
                FROM Producto p
                INNER JOIN Categoria c ON (p.id_categoria = c.id_categoria)
                LEFT JOIN Especie e ON (p.id_especie = e.id_especie)
                LEFT JOIN Tamano t ON (p.id_tamano = t.id_tamano)
                WHERE p.stock_actual <= p.stock_minimo 
                ORDER BY p.stock_actual ASC";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable ObtenerVentasYMetodosPago(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dataTable = new DataTable();

            string query = @"
                SELECT 
                    v.id_venta AS [ID Venta], 
                    v.nro_factura AS [Nro. Factura], 
                    v.fecha_hora AS [Fecha y Hora],
                    CONCAT(u.nombre, ' ', u.apellido) AS [Vendedor],
                    v.descuento AS [Descuento],
                    v.total AS [Total]
                FROM Venta v
                INNER JOIN Usuario u ON (v.id_usuario = u.id_usuario)
                WHERE CAST(v.fecha_hora AS DATE) BETWEEN @fechaInicio AND @fechaFin
                ORDER BY v.fecha_hora DESC";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = fechaInicio.Date;
                cmd.Parameters.Add("@FechaFin", SqlDbType.Date).Value = fechaFin.Date;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable ObtenerProductoVendidos(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dataTable = new DataTable();
            string query = @"
                SELECT TOP 10
                    p.nombre_producto AS [Producto],
                    c.nombre_categoria AS [Categoría],
                    SUM(dv.cantidad) AS [Unidades Vendidas],
                    SUM(dv.cantidad * dv.precio_unitario) AS [Total Generado]
                FROM Detalle_Venta dv
                INNER JOIN Producto p ON dv.id_producto = p.id_producto
                INNER JOIN Categoria c ON p.id_categoria = c.id_categoria
                INNER JOIN Venta v ON dv.id_venta = v.id_venta
                WHERE CAST(v.fecha_hora AS DATE) BETWEEN @fechaInicio AND @fechaFin
                GROUP BY p.nombre_producto, c.nombre_categoria
                ORDER BY [Unidades Vendidas] DESC;";

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conexion))
            {
                cmd.Parameters.Add("@fechaInicio", SqlDbType.Date).Value = fechaInicio.Date;
                cmd.Parameters.Add("@fechaFin", SqlDbType.Date).Value = fechaFin.Date;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
    }
}
