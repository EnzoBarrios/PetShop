using PetShop.Datos;
using PetShop.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PetShop.Negocio
{
    public class CN_Venta
    {
        private readonly CD_Venta _cdvVenta = new CD_Venta();

        public string ObtenerProximoNroFactura()
        {
            return _cdvVenta.ObtenerProximoNroFactura();
        }

        public List<TipoVenta> ListarTiposVenta()
        {
            return _cdvVenta.ListarTiposVenta();
        }

        public List<MetodoPago> ListarMetodosPago()
        {
            return _cdvVenta.ListarMetodosPago();
        }

        // --- CÁLCULOS DE NEGOCIO (DESCUENTO Y TOTALES) ---
        public (decimal montoDescuento, decimal totalFinal, string textoDescuento) CalcularTotalesVenta(decimal subtotal, decimal valorDescuentoIngresado)
        {
            decimal montoDescuento = 0;
            string textoDescuento = "0%";

            if (valorDescuentoIngresado > 0)
            {
                // CASO 1: Si es <= 100 se toma como porcentaje (%)
                if (valorDescuentoIngresado <= 100)
                {
                    montoDescuento = subtotal * (valorDescuentoIngresado / 100);
                    textoDescuento = $"{valorDescuentoIngresado:0}% (${montoDescuento:F2})";
                }
                // CASO 2: Si es > 100 se toma como monto fijo en pesos ($)
                else
                {
                    montoDescuento = valorDescuentoIngresado > subtotal ? subtotal : valorDescuentoIngresado;
                    textoDescuento = $"${montoDescuento:F2}";
                }
            }

            decimal totalFinal = subtotal - montoDescuento;
            if (totalFinal < 0) totalFinal = 0;

            return (montoDescuento, totalFinal, textoDescuento);
        }

        public (decimal vuelto, bool esSuficiente) CalcularVuelto(decimal abonado, decimal totalFinal)
        {
            decimal vuelto = abonado - totalFinal;
            return (vuelto, vuelto >= 0);
        }

        public bool RegistrarVenta(Venta venta, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(venta.NroFactura))
            {
                venta.NroFactura = _cdvVenta.ObtenerProximoNroFactura();
            }

            if (venta.IdUsuario <= 0)
            {
                mensaje = "Debe haber un usuario válido asociado a la venta.";
                return false;
            }

            if (venta.IdTipoVenta <= 0)
            {
                mensaje = "Debe seleccionar un tipo de venta.";
                return false;
            }

            if (venta.Detalles == null || venta.Detalles.Count == 0)
            {
                mensaje = "No se puede registrar una venta sin productos.";
                return false;
            }

            var detallesAgrupados = venta.Detalles
                .GroupBy(d => d.IdProducto)
                .Select(g => new
                {
                    IdProducto = g.Key,
                    CantidadTotal = g.Sum(x => x.Cantidad)
                });

            CN_Producto cnProducto = new CN_Producto();

            foreach (var itemAgrupado in detallesAgrupados)
            {
                Producto prodActual = cnProducto.ObtenerPorId(itemAgrupado.IdProducto);

                if (prodActual == null)
                {
                    mensaje = $"El producto con ID {itemAgrupado.IdProducto} no existe en la base de datos.";
                    return false;
                }

                if (!prodActual.Estado)
                {
                    mensaje = $"El producto '{prodActual.Nombre}' se encuentra inactivo y no se puede vender.";
                    return false;
                }

                if (itemAgrupado.CantidadTotal <= 0)
                {
                    mensaje = $"La cantidad para el producto '{prodActual.Nombre}' debe ser mayor a 0.";
                    return false;
                }

                if (prodActual.StockActual < itemAgrupado.CantidadTotal)
                {
                    mensaje = $"Stock insuficiente para '{prodActual.Nombre}'. Disponible: {prodActual.StockActual}, Solicitado en total: {itemAgrupado.CantidadTotal}.";
                    return false;
                }
            }

            venta.CalcularTotal();

            if (venta.Total <= 0)
            {
                mensaje = "El total de la venta debe ser mayor a $0.";
                return false;
            }

            if (venta.Pagos == null || venta.Pagos.Count == 0)
            {
                mensaje = "Debe registrar al menos un método de pago.";
                return false;
            }

            decimal totalPagado = 0;
            foreach (var pago in venta.Pagos)
            {
                if (pago.Monto <= 0)
                {
                    mensaje = "Los montos abonados deben ser mayores a $0.";
                    return false;
                }
                totalPagado += pago.Monto;
            }

            if (totalPagado < venta.Total)
            {
                mensaje = $"El monto total abonado (${totalPagado:F2}) es menor al total de la venta (${venta.Total:F2}).";
                return false;
            }

            return _cdvVenta.RegistrarVenta(venta, out mensaje);
        }

        public DataTable ObtenerHistorialVentas(DateTime desde, DateTime hasta, int idMetodoPago = 0)
        {
            return _cdvVenta.ObtenerHistorialVentas(desde, hasta, idMetodoPago);
        }

        public DataTable ObtenerDetalleVentaPorTicket(string nroTicket)
        {
            if (string.IsNullOrWhiteSpace(nroTicket))
            {
                return new DataTable();
            }

            return _cdvVenta.ObtenerDetalleVentaPorTicket(nroTicket);
        }
    }
}