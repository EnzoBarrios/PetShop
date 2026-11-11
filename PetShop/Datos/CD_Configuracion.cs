using System;
using System.Data.SqlClient;

namespace PetShop.Datos
{
    public class CD_Configuracion
    {
        public bool ObtenerPermisoBackupGerente()
        {
            bool tienePermiso = false;

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT valor FROM Configuracion WHERE clave = 'PermisoBackupGerente'";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        tienePermiso = resultado.ToString().Trim() == "1";
                    }
                }
                catch (Exception)
                {
                    // Ante un error de conexión o lectura, por seguridad retorna false
                    tienePermiso = false;
                }
            }

            return tienePermiso;
        }

        public bool ActualizarPermisoBackupGerente(bool habilitado, out string mensaje)
        {
            bool exito = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = ConexionBd.CrearConexion())
            {
                try
                {
                    conexion.Open();
                    string valor = habilitado ? "1" : "0";
                    string query = "UPDATE Configuracion SET valor = @valor WHERE clave = 'PermisoBackupGerente'";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@valor", valor);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        exito = true;
                        mensaje = "Permiso actualizado correctamente en la base de datos.";
                    }
                    else
                    {
                        exito = false;
                        mensaje = "No se encontró el parámetro de configuración.";
                    }
                }
                catch (Exception ex)
                {
                    exito = false;
                    mensaje = "Error al actualizar el permiso: " + ex.Message;
                }
            }

            return exito;
        }
    }
}