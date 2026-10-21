using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private readonly ErrorProvider _ep = new ErrorProvider();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            txtClave.UseSystemPasswordChar = true;

            // Configuración visual del validador
            _ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _ep.Icon = System.Drawing.SystemIcons.Warning;

            // Asignación de atajos de teclado Enter y Esc
            this.AcceptButton = btnIngresar;
            this.CancelButton = btnCancelar;
        }
        
        // 
        private bool ValidarCamposLogin()
        {
            _ep.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                _ep.SetError(txtUsuario, "Ingrese su nombre de Usuario");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                _ep.SetError(txtClave, "Ingrese su contraseña");
                esValido = false;
            }

            return esValido;
        }

        // BOTON INGRESAR
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposLogin())
            {
                MessageBox.Show("Por favor, verifique los campos marcados con advertencias.",
                   "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuarioIngresado = txtUsuario.Text.Trim();
            string claveIngresada = txtClave.Text.Trim();

            Usuario usuarioLogueado = _cnUsuario.IniciarSesion(usuarioIngresado, claveIngresada, out string mensajeError);

            if (usuarioLogueado != null)
            {
                txtClave.Clear();

                FormMenuPrincipal formMenu = new FormMenuPrincipal(usuarioLogueado);
                formMenu.FormClosed += CerrarSesion;

                this.Hide();
                formMenu.Show();
            }
            else
            {
                MessageBox.Show(mensajeError, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (sender is Form formCerrado)
            {
                formCerrado.FormClosed -= CerrarSesion;
            }

            txtUsuario.Clear();
            txtClave.Clear();
            _ep.Clear();
            txtUsuario.Focus();

            this.Show();
        }
    }
}
