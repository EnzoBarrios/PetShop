using System;
using System.Collections.Generic;
using System.Linq; // Necesario para GroupBy y Sum
using PetShop.Datos;
using PetShop.Entidades;

namespace PetShop.Negocio
{
    public class CN_Venta
    {
        private CD_Venta _cdvVenta = new CD_Venta();

        public string ObtenerProximoNroFactura()
        {
            return _cdvVenta.ObtenerProximoNroFactura();
        }

        public bool RegistrarVenta(Venta venta, out string mensaje)
        {
            mensaje = string.Empty;

            // 1. Asignar Número de Factura automáticamente si no viene asignado
            if (string.IsNullOrWhiteSpace(venta.NroFactura))
            {
                venta.NroFactura = _cdvVenta.ObtenerProximoNroFactura();
            }

            // 2. Validaciones básicas de encabezado
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

            // 3. Agrupar ÍTEMS DUPLICADOS para sumar cantidades del mismo producto
            var detallesAgrupados = venta.Detalles
                .GroupBy(d => d.IdProducto)
                .Select(g => new
                {
                    IdProducto = g.Key,
                    CantidadTotal = g.Sum(x => x.Cantidad)
                });

            CN_Producto cnProducto = new CN_Producto();

            // 4. Validar ESTADO DEL PRODUCTO y STOCK disponible por total acumulado
            foreach (var itemAgrupado in detallesAgrupados)
            {
                Producto prodActual = cnProducto.ObtenerPorId(itemAgrupado.IdProducto);

                if (prodActual == null)
                {
                    mensaje = $"El producto con ID {itemAgrupado.IdProducto} no existe en la base de datos.";
                    return false;
                }

                // Validación de Estado Activo
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

                // Validación de Stock Acumulado
                if (prodActual.Stock < itemAgrupado.CantidadTotal)
                {
                    mensaje = $"Stock insuficiente para '{prodActual.Nombre}'. Disponible: {prodActual.Stock}, Solicitado en total: {itemAgrupado.CantidadTotal}.";
                    return false;
                }
            }

            // 5. Recalcular e integrar el Total
            venta.CalcularTotal();
            if (venta.Total <= 0)
            {
                mensaje = "El total de la venta debe ser mayor a $0.";
                return false;
            }

            // 6. Validar MÉTODOS DE PAGO
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
                mensaje = $"El monto total abonado (${totalPagado}) es menor al total de la venta (${venta.Total}).";
                return false;
            }

            // Guardar en la base de datos
            return _cdvVenta.RegistrarVenta(venta, out mensaje);
        }
    }
}