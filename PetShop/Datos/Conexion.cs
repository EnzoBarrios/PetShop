using System;
using System.Configuration; // Requiere agregar la referencia si marca error
using System.Data.SqlClient;

namespace PetShop
{
    public static class Conexion
    {
        private static string _cadenaConexion;

        public static string CadenaConexion
        {
            get
            {
                // Si ya encontramos la cadena válida previamente, la reutilizamos
                if (!string.IsNullOrEmpty(_cadenaConexion))
                    return _cadenaConexion;

                string cadenaExpress = ConfigurationManager.ConnectionStrings["PetShop_Express"]?.ConnectionString;
                string cadenaLocal = ConfigurationManager.ConnectionStrings["PetShop_Local"]?.ConnectionString;

                // 1. Prueba la conexión de SQL Express (Franco)
                if (!string.IsNullOrEmpty(cadenaExpress) && ProbarConexion(cadenaExpress))
                {
                    _cadenaConexion = cadenaExpress;
                    return _cadenaConexion;
                }

                // 2. Prueba tu conexión local (.)
                if (!string.IsNullOrEmpty(cadenaLocal) && ProbarConexion(cadenaLocal))
                {
                    _cadenaConexion = cadenaLocal;
                    return _cadenaConexion;
                }

                // Si ninguna conectó, asigna la local por defecto para que salte la excepción habitual al consultar
                _cadenaConexion = cadenaLocal ?? cadenaExpress;
                return _cadenaConexion;
            }
        }

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }

        private static bool ProbarConexion(string conexionString)
        {
            try
            {
                // Timeout reducido a 2 segundos para no demorar el inicio del sistema
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(conexionString)
                {
                    ConnectTimeout = 2
                };

                using (SqlConnection con = new SqlConnection(builder.ConnectionString))
                {
                    con.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}