using PetShop.Entidades;
using PetShop.Presentacion.Autenticacion;
using PetShop.Presentacion.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Crear un usuario de prueba como Administrador para habilitar los menús
            // Usuario usuarioPrueba = new Usuario
            // {
            //      IdUsuario = 1,
            //     NombreUsuario = "admin",
            //     Rol = new Rol { IdRol = 1, NombreRol = "Administrador" }
            //};

            // 2. Iniciar directamente el Menú Principal pasándole el usuario simulado
            // Application.Run(new FormMenuPrincipal(usuarioPrueba));
            Application.Run(new FormLogin());
        }
    }
}
