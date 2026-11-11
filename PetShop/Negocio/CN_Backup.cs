using System;
using PetShop.Datos;

namespace PetShop.Negocio
{
    public class CN_Backup
    {
        private readonly CD_Backup _cdBackup = new CD_Backup();

        public bool GenerarCopiaSeguridad(string rutaDestino, out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(rutaDestino))
            {
                mensaje = "Debe seleccionar una ruta válida para guardar la copia de seguridad.";
                return false;
            }

            return _cdBackup.GenerarCopiaSeguridad(rutaDestino, out mensaje);
        }
    }
}