using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PetShop.Entidades;

namespace PetShop.Datos
{
    public class CD_Venta
    {
        // Genera el próximo número correlativo como string ("00000001")
        public string ObtenerProximoNroFactura()
        {
            string proximoNro = "00000001";
            using (SqlConnection conexion = ConexionBd.CrearConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT ISNULL(MAX(CAST(nro_factura AS INT)), 0) + 1 FROM Venta WHERE ISNUMERIC(nro_factura) = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    int ultimoId = Convert.ToInt32(cmd.ExecuteScalar());
                    proximoNro = ultimoId.ToString("D8");
                }
                catch (Exception)
                {
                    proximoNro = "00000001";
                }
            }
            return proximoNro;
        }

        // Listar los tipos de venta desde la base de datos
        public List<TipoVenta> ListarTiposVenta()
        {
            List<TipoVenta> lista = new List<TipoVenta>();
            using (SqlConnection conexion = ConexionBd.CrearConexion())
            {
                try
                {
                    string query = "SELECT id_tipo_venta, descripcion FROM Tipo_venta";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new TipoVenta
                            {
                                IdTipoVenta = Convert.ToInt32(dr["id_tipo_venta"]),
                                Descripcion = dr["descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al consultar los tipos de venta: " + ex.Message);
                }
            }
            return lista;
        }

        // Listar los métodos de pago desde la base de datos
        public List<MetodoPago> ListarMetodosPago()
        {
            List<MetodoPago> lista = new List<MetodoPago>();
            using (SqlConnection conexion = ConexionBd.CrearConexion())
            {
                try
                {
                    string query = "SELECT id_metodo_pago, nombre_metodo FROM Metodo_pago";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new MetodoPago
                            {
                                IdMetodoPago = Convert.ToInt32(dr["id_metodo_pago"]),
                                NombreMetodo = dr["nombre_metodo"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al consultar los métodos de pago: " + ex.Message);
                }
            }
            return lista;
        }

        // Registro de venta con Transacción SQL
        public bool RegistrarVenta(Venta venta, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            {
                conexion.Open();
                SqlTransaction objTransaction = conexion.BeginTransaction();

                try
                {
                    // 1. Insertar Venta
                    string queryVenta = @"
                        INSERT INTO Venta (nro_factura, fecha_hora, total, descuento, estado, id_tipo_venta, id_usuario)
                        VALUES (@nro_factura, @fecha_hora, @total, @descuento, @estado, @id_tipo_venta, @id_usuario);
                        SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdVenta = new SqlCommand(queryVenta, conexion, objTransaction);
                    cmdVenta.Parameters.AddWithValue("@nro_factura", venta.NroFactura);
                    cmdVenta.Parameters.AddWithValue("@fecha_hora", venta.FechaHora);
                    cmdVenta.Parameters.AddWithValue("@total", venta.Total);
                    cmdVenta.Parameters.AddWithValue("@descuento", venta.Descuento);
                    cmdVenta.Parameters.AddWithValue("@estado", string.IsNullOrEmpty(venta.Estado) ? "Completada" : venta.Estado);
                    cmdVenta.Parameters.AddWithValue("@id_tipo_venta", venta.IdTipoVenta);
                    cmdVenta.Parameters.AddWithValue("@id_usuario", venta.IdUsuario);

                    int idVentaGenerado = Convert.ToInt32(cmdVenta.ExecuteScalar());
                    venta.IdVenta = idVentaGenerado;

                    // 2. Insertar Detalles y Descontar Stock
                    foreach (DetalleVenta dv in venta.Detalles)
                    {
                        string queryDetalle = @"
                            INSERT INTO Detalle_Venta (id_venta, id_producto, cantidad, precio_unitario, subtotal)
                            VALUES (@id_venta, @id_producto, @cantidad, @precio_unitario, @subtotal)";

                        SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conexion, objTransaction);
                        cmdDetalle.Parameters.AddWithValue("@id_venta", idVentaGenerado);
                        cmdDetalle.Parameters.AddWithValue("@id_producto", dv.IdProducto);
                        cmdDetalle.Parameters.AddWithValue("@cantidad", dv.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@precio_unitario", dv.PrecioUnitario);
                        cmdDetalle.Parameters.AddWithValue("@subtotal", dv.Subtotal);
                        cmdDetalle.ExecuteNonQuery();

                        string queryStock = @"
                            UPDATE Producto 
                            SET stock_actual = stock_actual - @cantidad 
                            WHERE id_producto = @id_producto";

                        SqlCommand cmdStock = new SqlCommand(queryStock, conexion, objTransaction);
                        cmdStock.Parameters.AddWithValue("@cantidad", dv.Cantidad);
                        cmdStock.Parameters.AddWithValue("@id_producto", dv.IdProducto);
                        cmdStock.ExecuteNonQuery();
                    }

                    // 3. Insertar Pagos
                    if (venta.Pagos != null)
                    {
                        foreach (Pago pago in venta.Pagos)
                        {
                            string queryPago = @"
                                INSERT INTO Pago (id_venta, id_metodo_pago, monto)
                                VALUES (@id_venta, @id_metodo_pago, @monto)";

                            SqlCommand cmdPago = new SqlCommand(queryPago, conexion, objTransaction);
                            cmdPago.Parameters.AddWithValue("@id_venta", idVentaGenerado);
                            cmdPago.Parameters.AddWithValue("@id_metodo_pago", pago.IdMetodoPago);
                            cmdPago.Parameters.AddWithValue("@monto", pago.Monto);
                            cmdPago.ExecuteNonQuery();
                        }
                    }

                    objTransaction.Commit();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    objTransaction.Rollback();
                    mensaje = "Error al registrar la venta: " + ex.Message;
                    respuesta = false;
                }
            }

            return respuesta;
        }
    }
}