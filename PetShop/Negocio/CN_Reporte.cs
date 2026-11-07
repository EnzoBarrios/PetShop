using System;
using System.Data;
using PetShop.Datos;

namespace PetShop.Negocio
{
    public class CN_Reporte
    {
        private readonly CD_Reporte _cdReporte;

        public CN_Reporte()
        {
            _cdReporte = new CD_Reporte();
        }

        public DataTable ObtenerStockCritico()
        {
            return _cdReporte.ObtenerStockCritico();
        }

        public DataTable ObtenerVentasYMetodosPago(DateTime fechaInicio, DateTime fechaFin)
        {
            // Validación de regla de negocio para fechas
            if (fechaInicio.Date > fechaFin.Date)
            {
                throw new ArgumentException("La fecha de inicio no puede ser mayor que la fecha de fin.");
            }
            return _cdReporte.ObtenerVentasYMetodosPago(fechaInicio, fechaFin);
        }

        public DataTable ObtenerProductosVendidos(DateTime fechaInicio, DateTime fechaFin)
        {
            // Validación de regla de negocio para fechas
            if (fechaInicio.Date > fechaFin.Date)
            {
                throw new ArgumentException("La fecha de inicio no puede ser mayor que la fecha de fin.");
            }
            return _cdReporte.ObtenerProductoVendidos(fechaInicio, fechaFin);
        }
    }
}
