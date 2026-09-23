using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Datos;
using PetShop.Entidades;

namespace PetShop.Negocio
{
    public class CN_Rol
    {
        private readonly CD_Rol _cdRol = new CD_Rol();

        // Obtiene todos los roles sin restricciones
        public List<Rol> ListarRoles()
        {
            return _cdRol.Listar();
        }

        // Filtra los roles disponibles según quién esté registrando/modificando
        public List<Rol> ObtenerRolesPermitidos(string rolUsuarioLogueado)
        {
            List<Rol> todosLosRoles = _cdRol.Listar();

            if (rolUsuarioLogueado.Equals("Gerente", StringComparison.OrdinalIgnoreCase))
            {
                // El gerente solo puede crear o asignar rol "Vendedor"
                return todosLosRoles
                    .Where(r => r.NombreRol.Equals("Vendedor", StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            if (rolUsuarioLogueado.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
            {
                // El administrador puede asignar "Gerente" o "Vendedor"
                return todosLosRoles
                    .Where(r => !r.NombreRol.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            return new List<Rol>();
        }
    }
}
