using System;
using System.Data.SqlClient;

namespace PetShop.Datos
{
    public class CD_Backup
    {
        public bool GenerarCopiaSeguridad(string rutaDestino, out string mensaje)
        {
            bool exito = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            {
                try
                {
                    conexion.Open();

                    // 1. Obtiene el nombre real de la base de datos directamente de la conexión
                    string nombreBD = conexion.Database;

                    // 2. Inyectamos las variables directamente en el string. 
                    // Para comandos de administración (BACKUP), esto evita errores de parámetros.
                    string query = $@"
                BACKUP DATABASE [{nombreBD}] 
                TO DISK = '{rutaDestino}' 
                WITH FORMAT, MEDIANAME = 'PetShopBackups', NAME = 'Full Backup de {nombreBD}';";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    // Aumentamos el Timeout a 2 minutos para bases de datos pesadas
                    cmd.CommandTimeout = 120;

                    cmd.ExecuteNonQuery();

                    exito = true;
                    mensaje = "La copia de seguridad se generó correctamente.";
                }
                catch (Exception ex)
                {
                    exito = false;
                    mensaje = "Error al generar el backup: " + ex.Message;
                }
            }

            return exito;
        }
    }
}