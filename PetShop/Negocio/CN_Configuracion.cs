using PetShop.Datos;

namespace PetShop.Negocio
{
    public class CN_Configuracion
    {
        private readonly CD_Configuracion _cdConfiguracion = new CD_Configuracion();

        public bool ObtenerPermisoBackupGerente()
        {
            return _cdConfiguracion.ObtenerPermisoBackupGerente();
        }

        public bool ActualizarPermisoBackupGerente(bool habilitado, out string mensaje)
        {
            return _cdConfiguracion.ActualizarPermisoBackupGerente(habilitado, out mensaje);
        }
    }
}