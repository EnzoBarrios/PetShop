using System;
using System.Configuration; // Requiere agregar la referencia si marca error
using System.Data.SqlClient;

namespace PetShop.Datos
{
    public static class ConexionBd
    {
        private static readonly string _cadenaConexion;

        static ConexionBd()
        {   
            string cadenaExpress = ConfigurationManager.ConnectionStrings["PetShop_Express"]?.ConnectionString;
            string cadenaLocal = ConfigurationManager.ConnectionStrings["PetShop_Local"]?.ConnectionString;

            if (!string.IsNullOrWhiteSpace(cadenaExpress) && ProbarConexion(cadenaExpress))
            {
                // 1. Prueba la conexión de SQL Express (Franco)
                _cadenaConexion = cadenaExpress;
            }
            else if (!string.IsNullOrWhiteSpace(cadenaExpress) && ProbarConexion(cadenaLocal))
            {
                // Prueba la conexión de SQL Developer (Enzo)
                _cadenaConexion = cadenaLocal;
            }
            else
            {
                // Si ninguna conectó, asigna la local por defecto para que salte la excepción habitual al consultar
                _cadenaConexion = cadenaLocal ?? cadenaExpress ?? string.Empty;
            }
        }

        public static SqlConnection CrearConexion()
        {
            if (string.IsNullOrWhiteSpace(_cadenaConexion))
            {
                throw new InvalidOperationException("No se ha configurado ninguna cadena de conexión válida en App.config.");
            }

            return new SqlConnection(_cadenaConexion);
        }

        private static bool ProbarConexion(string conexionString)
        {
            if (string.IsNullOrWhiteSpace(conexionString)) {
                return false;
            }

            try
            {
                // Timeout reducido a 2 segundos para no demorar el inicio del sistema
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(conexionString)
                {
                    ConnectTimeout = 2
                };

                using (SqlConnection con = new SqlConnection(builder.ConnectionString))
                {
                    con.Open(); // Prueba física de enlace al motor
                    return true;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}