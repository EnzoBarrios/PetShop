using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.Negocio;
using PetShop.Entidades;
using PetShop.Presentacion.Menu;

namespace PetShop.Presentacion.Autenticacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // BOTON INGRESAR
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text.Trim();
            string claveIngresada = txtClave.Text.Trim();

            if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(claveIngresada))
            {
                MessageBox.Show("Debe completar todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuarioLogueado = new CN_Usuario().ListarUsuarios()
                .FirstOrDefault(u => u.NombreUsuario.Trim().Equals(usuarioIngresado, StringComparison.OrdinalIgnoreCase)
                                  && u.Clave.Trim() == claveIngresada);

            if (!usuarioLogueado.Estado)
            {
                MessageBox.Show($"El usuario '{usuarioLogueado.NombreUsuario}' se encuentra inactivo.\nContacte al administrador para habilitar el acceso.",
                                "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usuarioLogueado != null)
            {
                MessageBox.Show("Bienvenido al sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMenuPrincipal form = new FormMenuPrincipal(usuarioLogueado);
                form.FormClosed += CerrarSesion;

                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTON CANCELAR
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para cerrar sesión y volver al formulario de login
        private void CerrarSesion(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtClave.Text = "";

            this.Show();
        }
    }
}
