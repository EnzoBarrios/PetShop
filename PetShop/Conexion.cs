using System;
using System.Configuration; // Requiere agregar la referencia si marca error
using System.Data.SqlClient;

namespace PetShop
{
    public static class Conexion
    {
        // Obtiene la cadena definida en App.config según la PC donde se ejecute
        private static string cadenaConexion = ConfigurationManager.ConnectionStrings["PetShopConnection"].ConnectionString;

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}