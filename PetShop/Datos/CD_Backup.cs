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

                    // Sentencia T-SQL para respaldar la base de datos PetShopDB
                    string query = $@"
                        BACKUP DATABASE [PetShopDB] 
                        TO DISK = @rutaDestino 
                        WITH FORMAT, MEDIANAME = 'PetShopBackups', NAME = 'Full Backup de PetShopDB';";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    // Aumentamos el Timeout porque un backup puede demorar unos segundos
                    cmd.CommandTimeout = 120;
                    cmd.Parameters.AddWithValue("@rutaDestino", rutaDestino);

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