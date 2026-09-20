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

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text.Trim();
            string claveIngresada = txtClave.Text.Trim();

            if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(claveIngresada))
            {
                MessageBox.Show("Debe completar todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuarioLogeado = new CN_Usuario().Listar()
                .FirstOrDefault(u => u.NombreUsuario.Trim().Equals(usuarioIngresado, StringComparison.OrdinalIgnoreCase)
                                  && u.Clave.Trim() == claveIngresada
                                  && u.Estado == true);

            if (usuarioLogeado != null)
            {
                MessageBox.Show("Bienvenido al sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMenuPrincipal form = new FormMenuPrincipal(usuarioLogeado);
                form.FormClosed += cerrar_sesion;

                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrar_sesion(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtClave.Text = "";

            this.Show();
        }
    }
}
