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
        private readonly CN_Usuario _cnUsuario = new CN_Usuario();

        public FormLogin()
        {
            InitializeComponent();
        }

        public void FormLoginLoad(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = true;
        }

        // BOTON INGRESAR
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text.Trim();
            string claveIngresada = txtClave.Text.Trim();

            Usuario usuarioLogueado = _cnUsuario.IniciarSesion(usuarioIngresado, claveIngresada, out string mensajeError);

            if (usuarioLogueado != null)
            {
                FormMenuPrincipal formMenu = new FormMenuPrincipal(usuarioLogueado);
                formMenu.FormClosed += CerrarSesion;

                this.Hide();
                formMenu.Show();
            }
            else
            {
                MessageBox.Show(mensajeError, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Clear();
                txtClave.Focus();
            }
        }

        // BOTON CANCELAR
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Método para cerrar sesión y volver al formulario de login
        private void CerrarSesion(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtClave.Clear();
            txtUsuario.Focus();
            this.Show();
        }
    }
}
