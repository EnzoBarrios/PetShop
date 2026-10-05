using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PetShop.Negocio;
using PetShop.Entidades;

namespace PetShop.Presentacion.Usuarios
{
    public partial class FormMiPerfil : Form
    {
        private readonly int _idUsuarioActual;
        private readonly ErrorProvider _ep = new ErrorProvider();
        private readonly CN_Usuario _cnUsuario = new CN_Usuario();

        public FormMiPerfil(int idUsuario)
        {
            InitializeComponent();
            _idUsuarioActual = idUsuario;
        }

        public FormMiPerfil() : this(0)
        {
        }

        private void FormMiPerfil_Load(object sender, EventArgs e)
        {
            if (_idUsuarioActual <= 0)
            {
                MessageBox.Show("No se detectó una sesión de usuario válida.", 
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            CargarDatosPerfil();
            ConfigurarControles();
            AsignarEventosRestriccionTeclas();
        }

        private void ConfigurarControles()
        {
            _ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _ep.Icon = SystemIcons.Warning;

            txtClave.UseSystemPasswordChar = true;
            txtConfirmar.UseSystemPasswordChar = true;

            // El rol no es editable por el propio usuario
            txtRol.ReadOnly = true;
            txtRol.TabStop = false;
            txtRol.BackColor = Color.FromArgb(235, 238, 242);
        }

        private void AsignarEventosRestriccionTeclas()
        {
            txtNombre.KeyPress += SoloLetras_KeyPress;
            txtApellido.KeyPress += SoloLetras_KeyPress;
            txtDni.KeyPress += SoloNumeros_KeyPress;
            txtTelefono.KeyPress += SoloTelefono_KeyPress;
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoloTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }

        private void CargarDatosPerfil()
        {
            try
            {
                Usuario usuario = _cnUsuario.ObtenerPorId(_idUsuarioActual);

                if (usuario != null)
                {
                    txtNombre.Text = usuario.Nombre;
                    txtApellido.Text = usuario.Apellido;
                    txtNombreUsuario.Text = usuario.NombreUsuario;
                    txtRol.Text = usuario.Rol?.NombreRol ?? "Sin Rol";
                    txtDni.Text = usuario.Dni ?? string.Empty;
                    txtCorreo.Text = usuario.Correo ?? string.Empty;
                    txtTelefono.Text = usuario.Telefono ?? string.Empty;
                }
                else
                {
                    MessageBox.Show("No se encontraron los datos del perfil para el ID: " + _idUsuarioActual, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del perfil desde la base de datos: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarFormulario()
        {
            _ep.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                _ep.SetError(txtNombre, "El nombre no puede estar vacío.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                _ep.SetError(txtApellido, "El apellido no puede estar vacío.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                _ep.SetError(txtNombreUsuario, "El nombre de usuario no puede estar vacío.");
                esValido = false;
            }

            string correo = txtCorreo.Text.Trim();
            if (!string.IsNullOrEmpty(correo))
            {
                string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(correo, patronEmail))
                {
                    _ep.SetError(txtCorreo, "Ingrese un correo electrónico válido.");
                    esValido = false;
                }
            }

            string telefono = txtTelefono.Text.Trim();
            if (!string.IsNullOrEmpty(telefono))
            {
                if (!Regex.IsMatch(telefono, @"^[0-9+\s\-]+$"))
                {
                    _ep.SetError(txtTelefono, "El teléfono contiene caracteres no válidos.");
                    esValido = false;
                }
            }

            bool contrasenaEscrita = !string.IsNullOrWhiteSpace(txtClave.Text);
            bool confirmacionEscrita = !string.IsNullOrWhiteSpace(txtConfirmar.Text);

            if (contrasenaEscrita || confirmacionEscrita)
            {
                if (txtClave.Text.Trim().Length < 6)
                {
                    _ep.SetError(txtClave, "La contraseña debe tener al menos 6 caracteres.");
                    esValido = false;
                }

                if (!txtConfirmar.Text.Equals(txtClave.Text))
                {
                    _ep.SetError(txtConfirmar, "Las contraseñas no coinciden.");
                    esValido = false;
                }
            }

            return esValido;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                MessageBox.Show("Por favor, verifique los campos marcados con error antes de continuar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea guardar los cambios en su perfil?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion != DialogResult.Yes) return;

            bool actualizarClave = !string.IsNullOrWhiteSpace(txtClave.Text);
            string claveNueva = txtClave.Text.Trim();

            Usuario usuarioActualizado = new Usuario
            {
                IdUsuario = _idUsuarioActual,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                NombreUsuario = txtNombreUsuario.Text.Trim(),
                Dni = string.IsNullOrWhiteSpace(txtDni.Text) ? null : txtDni.Text.Trim(),
                Correo = string.IsNullOrWhiteSpace(txtCorreo.Text) ? null : txtCorreo.Text.Trim(),
                Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
            };

            bool exito = _cnUsuario.ModificarUsuario(usuarioActualizado, actualizarClave, claveNueva, out string mensaje);

            if (exito)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatosPerfil();
                txtClave.Clear();
                txtConfirmar.Clear();
                _ep.Clear();
            }
            else {
                if (mensaje.IndexOf("usuario", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    _ep.SetError(txtNombreUsuario, mensaje);
                    txtNombreUsuario.Focus();
                }
                else if (mensaje.IndexOf("correo", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    _ep.SetError(txtCorreo, mensaje);
                    txtCorreo.Focus();
                }
                else if (mensaje.IndexOf("dni", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    _ep.SetError(txtDni, mensaje);
                    txtDni.Focus();
                }
                else
                {
                    MessageBox.Show(mensaje, "Validación de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CambiarVisibilidadClave(TextBox claveTexto, Button botonCambiar)
        {
            claveTexto.UseSystemPasswordChar = !claveTexto.UseSystemPasswordChar;
            botonCambiar.Text = claveTexto.UseSystemPasswordChar ? "👁‍🗨" : "👁";
        }

        // BOTON VER CLAVE
        private void BtnVerClave_Click(object sender, EventArgs e)
        {
            CambiarVisibilidadClave(txtClave, (Button)sender);
        }

        // BOTON VER CONFIRMACION
        private void BtnVerConfirmar_Click(object sender, EventArgs e)
        {
            CambiarVisibilidadClave(txtConfirmar, (Button)sender);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}