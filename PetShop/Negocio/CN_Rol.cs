using System;
using System.Collections.Generic;
using System.Linq;
using PetShop.Datos;
using PetShop.Entidades;

namespace PetShop.Negocio
{
    public class CN_Rol
    {
        private readonly CD_Rol _cdRol = new CD_Rol();

        public const string ROL_ADMINISTRADOR = "Administrador";
        public const string ROL_GERENTE = "Gerente";
        public const string ROL_VENDEDOR = "Vendedor";

        // Obtiene todos los roles sin restricciones
        public List<Rol> ListarRoles()
        {
            try
            {
                return _cdRol.Listar() ?? new List<Rol>();
            }
            catch (Exception)
            {
                return new List<Rol>();
            }
        }

        // Filtra los roles disponibles según quién esté registrando/modificando
        public List<Rol> ObtenerRolesPermitidos(string rolUsuarioLogueado)
        {
            if (string.IsNullOrWhiteSpace(rolUsuarioLogueado))
            {
                return new List<Rol>();
            }

            string rolOperador = rolUsuarioLogueado.Trim();
            List<Rol> todosLosRoles = ListarRoles();

            if (rolOperador.Equals(ROL_ADMINISTRADOR, StringComparison.OrdinalIgnoreCase))
            {
                // El administrador gestiona a los gerentes o vendedores
                return todosLosRoles
                    .Where(r => r.NombreRol != null &&
                               (r.NombreRol.Trim().Equals(ROL_GERENTE, StringComparison.OrdinalIgnoreCase) ||
                                r.NombreRol.Trim().Equals(ROL_VENDEDOR, StringComparison.OrdinalIgnoreCase)))
                    .ToList();
            }

            if (rolOperador.Equals(ROL_GERENTE, StringComparison.OrdinalIgnoreCase))
            {
                // El gerente gestiona solo a los vendedores
                return todosLosRoles
                    .Where(r => r.NombreRol != null && 
                                r.NombreRol.Trim().Equals(ROL_VENDEDOR, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            return new List<Rol>();
        }
    }
}
