using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PetShop.Entidades;
using PetShop.Negocio;

namespace PetShop.Presentacion.Usuarios
{
    public partial class FormCargaUsuario : Form
    {
        // Instancias de las clases de negocio para manejar usuarios y roles
        private readonly ErrorProvider _ep = new ErrorProvider();
        private readonly CN_Usuario _cnUsuario = new CN_Usuario();
        private readonly CN_Rol _cnRol = new CN_Rol();
        private readonly string _rolOperadorActual;

        public FormCargaUsuario(string rolOperadorActual = CN_Rol.ROL_ADMINISTRADOR)
        {
            InitializeComponent();
            _rolOperadorActual = rolOperadorActual;
        }

        private void FormCargaUsuario_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            CargarRoles();
        }

        private void ConfigurarControles()
        {
            // Configuración visual del ErrorProvider (estático, ícono de advertencia)
            _ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _ep.Icon = System.Drawing.SystemIcons.Warning;

            // Ocultar caracteres de contraseñas por defecto
            txtClave.UseSystemPasswordChar = true;
            txtConfirmar.UseSystemPasswordChar = true;

            // Bloquear edición manual en ComboBox
            cbxRol.DropDownStyle = ComboBoxStyle.DropDownList;;

            // Filtrado de teclas en vivo (KeyPress)
            txtNombre.KeyPress += SoloLetras_KeyPress;
            txtpellido.KeyPress += SoloLetras_KeyPress;
            txtDni.KeyPress += SoloNumeros_KeyPress;
            txtTelefono.KeyPress += SoloNumeros_KeyPress;
        }

        private void CargarRoles()
        {
            try
            {
                List<Rol> rolesPermitidos = _cnRol.ObtenerRolesPermitidos(_rolOperadorActual);

                cbxRol.DataSource = null;
                cbxRol.DisplayMember = nameof(Rol.NombreRol);
                cbxRol.ValueMember = nameof(Rol.IdRol);
                cbxRol.DataSource = rolesPermitidos;
                cbxRol.SelectedIndex = -1; // No seleccionar ningún rol por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message, 
                                "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private bool ValidarFormulario()
        {
            _ep.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                _ep.SetError(txtNombre, "El nombre es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtpellido.Text))
            {
                _ep.SetError(txtpellido, "El apellido es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                _ep.SetError(txtNombreUsuario, "El nombre de usuario es obligatorio.");
                esValido = false;
            }
            else if (txtNombreUsuario.Text.Trim().Length < 4)
            {
                _ep.SetError(txtNombreUsuario, "El usuario debe tener al menos 4 caracteres.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                _ep.SetError(txtClave, "La contraseña es obligatoria.");
                esValido = false;
            }
            else if (txtClave.Text.Trim().Length < 6)
            {
                _ep.SetError(txtClave, "La contraseña debe tener al menos 6 caracteres.");
                esValido = false;
            }

            if (txtConfirmar.Text != txtClave.Text)
            {
                _ep.SetError(txtConfirmar, "Las contraseñas no coinciden.");
                esValido = false;
            }

            if (!EsCorreoValido(txtCorreo.Text.Trim()))
            {
                _ep.SetError(txtCorreo, "El formato del correo electrónico no es válido.");
                esValido = false;
            }

            if (!string.IsNullOrWhiteSpace(txtDni.Text) && 
                (txtDni.Text.Trim().Length < 7 || txtDni.Text.Trim().Length > 8))
            {
                _ep.SetError(txtDni, "El DNI debe tener entre 7 y 8 dígitos.");
                esValido = false;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && txtTelefono.Text.Trim().Length < 8)
            {
                _ep.SetError(txtTelefono, "El teléfono debe tener al menos 8 dígitos.");
                esValido = false;
            }

            if (cbxRol.SelectedIndex == -1 || cbxRol.SelectedValue == null)
            {
                _ep.SetError(cbxRol, "Debe seleccionar un rol para el usuario.");
                esValido = false;
            }

            return esValido;
        }

        private bool EsCorreoValido(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo)) return true;
            const string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        // BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones locales del formulario
            if (!ValidarFormulario())
            {
                MessageBox.Show("Por favor, verifique los campos marcados con advertencias.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cbxRol.SelectedValue?.ToString(), out int idRolSeleccionado))
            {
                MessageBox.Show("Seleccione un rol válido.", "Atención", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Entidad Usuario para transferir los datos
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtpellido.Text.Trim(),
                NombreUsuario = txtNombreUsuario.Text.Trim(),
                Dni = string.IsNullOrWhiteSpace(txtDni.Text) ? null : txtDni.Text.Trim(),
                Correo = string.IsNullOrWhiteSpace(txtCorreo.Text) ? null : txtCorreo.Text.Trim(),
                Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                Estado = true,
                Rol = new Rol { IdRol = idRolSeleccionado}
            };

            string claveTexto = txtClave.Text.Trim();

            // Transferir datos a la Capa de Negocio
            bool registrado = _cnUsuario.RegistrarUsuario(nuevoUsuario, claveTexto, out string mensaje); 

            if(registrado)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (mensaje.IndexOf("usuario", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    _ep.SetError(txtNombreUsuario, mensaje);
                    txtNombreUsuario.Focus();
                }
                else if (mensaje.IndexOf("dni", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    _ep.SetError(txtDni, mensaje);
                    txtDni.Focus();
                }
                else if (mensaje.IndexOf("correo", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    _ep.SetError(txtCorreo, mensaje);
                    txtCorreo.Focus();
                }
                else
                {
                    MessageBox.Show(mensaje, "Validación de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        // BOTON BORRAR
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            bool hayDatosCargados = !string.IsNullOrWhiteSpace(txtNombre.Text) ||
                                    !string.IsNullOrWhiteSpace(txtpellido.Text) ||
                                    !string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                                    !string.IsNullOrWhiteSpace(txtClave.Text) ||
                                    !string.IsNullOrWhiteSpace(txtConfirmar.Text) ||
                                    !string.IsNullOrWhiteSpace(txtDni.Text) ||
                                    !string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                                    !string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                                    cbxRol.SelectedIndex != -1;

            if (!hayDatosCargados)
            {
                MessageBox.Show("No hay datos ingresados para borrar.", "Formulario Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea limpiar todos los campos cargados?",
                "Confirmar Limpieza",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                txtNombre.Clear();
                txtpellido.Clear();
                txtNombreUsuario.Clear();
                txtClave.Clear();
                txtConfirmar.Clear();
                txtDni.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();
                cbxRol.SelectedIndex = -1;
                _ep.Clear();
                txtNombre.Focus();
            }
        }

        // BOTON VOLVER 
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}