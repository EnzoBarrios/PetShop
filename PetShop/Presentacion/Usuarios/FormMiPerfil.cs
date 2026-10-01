using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                MessageBox.Show("No se detectó una sesión de usuario válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            CargarDatosPerfil();
            AsignarEventosValidacion();
            AsignarEventosRestriccionTeclas();
        }

        private void AsignarEventosValidacion()
        {
            txtCorreo.Validating += ValidarCorreo;
            txtTelefono.Validating += ValidarTelefono;
            txtClave.Validating += ValidarClave;
            txtConfirmar.Validating += ValidarConfirmacion;
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

        private void ValidarCorreo(object sender, CancelEventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            if (!string.IsNullOrEmpty(correo))
            {
                string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(correo, patronEmail))
                {
                    _ep.SetError(txtCorreo, "Ingrese un correo electrónico válido (ejemplo@dominio.com).");
                    return;
                }
            }
            _ep.SetError(txtCorreo, string.Empty);
        }

        private void ValidarTelefono(object sender, CancelEventArgs e)
        {
            string telefono = txtTelefono.Text.Trim();
            if (!string.IsNullOrEmpty(telefono))
            {
                if (!Regex.IsMatch(telefono, @"^[0-9+\s\-]+$"))
                {
                    _ep.SetError(txtTelefono, "El teléfono solo debe contener números, espacios o guiones.");
                    return;
                }
            }
            _ep.SetError(txtTelefono, string.Empty);
        }

        private void ValidarClave(object sender, CancelEventArgs e)
        {
            bool contrasenaEscrita = !string.IsNullOrWhiteSpace(txtClave.Text);
            bool confirmacionEscrita = !string.IsNullOrWhiteSpace(txtConfirmar.Text);

            if (contrasenaEscrita || confirmacionEscrita)
            {
                if (txtClave.Text.Length < 6)
                {
                    _ep.SetError(txtClave, "La contraseña debe tener al menos 6 caracteres.");
                    return;
                }
            }
            _ep.SetError(txtClave, string.Empty);
        }

        private void ValidarConfirmacion(object sender, CancelEventArgs e)
        {
            bool contrasenaEscrita = !string.IsNullOrWhiteSpace(txtClave.Text);
            bool confirmacionEscrita = !string.IsNullOrWhiteSpace(txtConfirmar.Text);

            if (contrasenaEscrita || confirmacionEscrita)
            {
                if (txtConfirmar.Text != txtClave.Text)
                {
                    _ep.SetError(txtConfirmar, "Las contraseñas no coinciden.");
                    return;
                }
            }
            _ep.SetError(txtConfirmar, string.Empty);
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
                if (txtClave.Text.Length < 6)
                {
                    _ep.SetError(txtClave, "La contraseña debe tener al menos 6 caracteres.");
                    esValido = false;
                }

                if (txtConfirmar.Text != txtClave.Text)
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

            Usuario usuarioActualizado = new Usuario
            {
                IdUsuario = _idUsuarioActual,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                NombreUsuario = txtNombreUsuario.Text.Trim(),
                Dni = string.IsNullOrWhiteSpace(txtDni.Text) ? null : txtDni.Text.Trim(),
                Correo = string.IsNullOrWhiteSpace(txtCorreo.Text) ? null : txtCorreo.Text.Trim(),
                Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                Clave = actualizarClave ? txtClave.Text : null
            };

            bool exito = _cnUsuario.ActualizarPerfilUsuario(usuarioActualizado, actualizarClave, out string mensaje);

            if (exito)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatosPerfil();
                txtClave.Clear();
                txtConfirmar.Clear();
                _ep.Clear();
            }
            else
            {
                _ep.SetError(txtNombreUsuario, mensaje);
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVerClave_Click(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = !txtClave.UseSystemPasswordChar;
        }

        private void BtnVerConfirmar_Click(object sender, EventArgs e)
        {
            txtConfirmar.UseSystemPasswordChar = !txtConfirmar.UseSystemPasswordChar;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}