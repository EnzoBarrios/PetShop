using PetShop.Entidades;
using PetShop.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PetShop.Presentacion.Usuarios
{
    public partial class FormCargaUsuario : Form
    {
        // Instancias de las clases de negocio para manejar usuarios y roles
        private readonly ErrorProvider _ep = new ErrorProvider();
        private readonly CN_Usuario _cnUsuario = new CN_Usuario();
        private readonly CN_Rol _cnRol = new CN_Rol();
        
        public FormCargaUsuario()
        {
            InitializeComponent();
        }

        private void FormCargaUsuario_Load(object sender, EventArgs e)
        {
            // Configuración visual del ErrorProvider (estático, ícono de advertencia)
            _ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _ep.Icon = System.Drawing.SystemIcons.Warning;

            // Ocultar caracteres de contraseñas por defecto
            txtClave.UseSystemPasswordChar = true;
            txtConfirmar.UseSystemPasswordChar = true;

            // Bloquear edición manual en ComboBox
            cbxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarRoles();

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
                List<Rol> roles = _cnRol.ListarRoles();
                roles.RemoveAll(r => r.NombreRol.Equals("Administrador", StringComparison.OrdinalIgnoreCase));

                cbxRol.DataSource = null;
                cbxRol.DisplayMember = "NombreRol";
                cbxRol.ValueMember = "IdRol";
                cbxRol.DataSource = roles;
                cbxRol.SelectedIndex = -1; // No seleccionar ningún rol por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool EsCorreoValido(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo)) return true;
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        private void BtnVerClave_Click(object sender, EventArgs e)
        {
            bool estaEnmascarado = txtClave.UseSystemPasswordChar;
            txtClave.UseSystemPasswordChar = !estaEnmascarado;
            if (sender is Button boton) boton.Text = estaEnmascarado ? "👁‍🗨" : "👁";
        }

        private void BtnVerConfirmar_Click(object sender, EventArgs e)
        {
            bool estaEnmascarado = txtConfirmar.UseSystemPasswordChar;
            txtConfirmar.UseSystemPasswordChar = !estaEnmascarado;
            if (sender is Button boton) boton.Text = estaEnmascarado ? "👁‍🗨" : "👁";
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

            if (!string.IsNullOrWhiteSpace(txtDni.Text) && (txtDni.Text.Trim().Length < 7 || txtDni.Text.Trim().Length > 8))
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
                _ep.SetError(cbxRol, "Debe seleccionar un rol.");
                esValido = false;
            }

            return esValido;
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

            if (!int.TryParse(cbxRol.SelectedValue?.ToString(), out int idRol))
            {
                MessageBox.Show("Seleccione un rol válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Entidad Usuario para transferir los datos
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtpellido.Text.Trim(),
                NombreUsuario = txtNombreUsuario.Text.Trim(),
                Clave = txtClave.Text.Trim(),
                Dni = string.IsNullOrWhiteSpace(txtDni.Text) ? null : txtDni.Text.Trim(),
                Correo = string.IsNullOrWhiteSpace(txtCorreo.Text) ? null : txtCorreo.Text.Trim(),
                Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                IdRol = idRol
            };

            // Transferir datos a la Capa de Negocio
            bool resultado = _cnUsuario.RegistrarUsuario(nuevoUsuario, out string mensaje); 

            if(resultado)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // BOTON ELIMINAR TODO
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