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

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerStockCritico", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable ObtenerVentasPorVendedor(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerVentasPorVendedor", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = fechaInicio.Date;
                cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fechaFin.Date;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable ObtenerProductosVendidos(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerProductosVendidos", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = fechaInicio.Date;
                cmd.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = fechaFin.Date;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
    }
}
