using PetShop.Entidades;
using PetShop.Negocio;
using System;
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
            TClave.UseSystemPasswordChar = true;
            TConfirmar.UseSystemPasswordChar = true;

            // Bloquear edición manual en ComboBox
            CBRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarRoles();

            // Filtrado de teclas en vivo (KeyPress)
            TNombre.KeyPress += SoloLetras_KeyPress;
            TApellido.KeyPress += SoloLetras_KeyPress;
            TDni.KeyPress += SoloNumeros_KeyPress;
            TTelefono.KeyPress += SoloNumeros_KeyPress;
        }

        private void CargarRoles()
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    var roles = _cnRol.ListarRoles();

                    roles.RemoveAll(r => r.NombreRol.Equals("Administrador", StringComparison.OrdinalIgnoreCase));

                    CBRol.DataSource = null;
                    CBRol.DisplayMember = "NombreRol";
                    CBRol.ValueMember = "IdRol";
                    CBRol.DataSource = roles;
                    CBRol.SelectedIndex = -1; // No seleccionar ningún rol por defecto
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar roles: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void BVerClave_Click(object sender, EventArgs e)
        {
            bool estaEnmascarado = TClave.UseSystemPasswordChar;
            TClave.UseSystemPasswordChar = !estaEnmascarado;
            if (sender is Button boton) boton.Text = estaEnmascarado ? "👁‍🗨" : "👁";
        }

        private void BVerConfirmar_Click(object sender, EventArgs e)
        {
            bool estaEnmascarado = TConfirmar.UseSystemPasswordChar;
            TConfirmar.UseSystemPasswordChar = !estaEnmascarado;
            if (sender is Button boton) boton.Text = estaEnmascarado ? "👁‍🗨" : "👁";
        }

        private bool ValidarFormulario()
        {
            _ep.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(TNombre.Text))
            {
                _ep.SetError(TNombre, "El nombre es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(TApellido.Text))
            {
                _ep.SetError(TApellido, "El apellido es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(TNombreUsuario.Text))
            {
                _ep.SetError(TNombreUsuario, "El nombre de usuario es obligatorio.");
                esValido = false;
            }
            else if (TNombreUsuario.Text.Trim().Length < 4)
            {
                _ep.SetError(TNombreUsuario, "El usuario debe tener al menos 4 caracteres.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(TClave.Text))
            {
                _ep.SetError(TClave, "La contraseña es obligatoria.");
                esValido = false;
            }
            else if (TClave.Text.Trim().Length < 6)
            {
                _ep.SetError(TClave, "La contraseña debe tener al menos 6 caracteres.");
                esValido = false;
            }

            if (TConfirmar.Text != TClave.Text)
            {
                _ep.SetError(TConfirmar, "Las contraseñas no coinciden.");
                esValido = false;
            }

            if (!EsCorreoValido(TCorreo.Text.Trim()))
            {
                _ep.SetError(TCorreo, "El formato del correo electrónico no es válido.");
                esValido = false;
            }

            if (!string.IsNullOrWhiteSpace(TDni.Text) && (TDni.Text.Trim().Length < 7 || TDni.Text.Trim().Length > 8))
            {
                _ep.SetError(TDni, "El DNI debe tener entre 7 y 8 dígitos.");
                esValido = false;
            }

            if (!string.IsNullOrWhiteSpace(TTelefono.Text) && TTelefono.Text.Trim().Length < 8)
            {
                _ep.SetError(TTelefono, "El teléfono debe tener al menos 8 dígitos.");
                esValido = false;
            }

            if (CBRol.SelectedIndex == -1 || CBRol.SelectedValue == null)
            {
                _ep.SetError(CBRol, "Debe seleccionar un rol.");
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

            if (!int.TryParse(CBRol.SelectedValue?.ToString(), out int idRol))
            {
                MessageBox.Show("Seleccione un rol válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Entidad Usuario para transferir los datos
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = TNombre.Text.Trim(),
                Apellido = TApellido.Text.Trim(),
                NombreUsuario = TNombreUsuario.Text.Trim(),
                Clave = TClave.Text.Trim(),
                Dni = TDni.Text.Trim(),
                Correo = TCorreo.Text.Trim(),
                Telefono = TTelefono.Text.Trim(),
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
            bool hayDatosCargados = !string.IsNullOrWhiteSpace(TNombre.Text) ||
                                    !string.IsNullOrWhiteSpace(TApellido.Text) ||
                                    !string.IsNullOrWhiteSpace(TNombreUsuario.Text) ||
                                    !string.IsNullOrWhiteSpace(TClave.Text) ||
                                    !string.IsNullOrWhiteSpace(TConfirmar.Text) ||
                                    !string.IsNullOrWhiteSpace(TDni.Text) ||
                                    !string.IsNullOrWhiteSpace(TCorreo.Text) ||
                                    !string.IsNullOrWhiteSpace(TTelefono.Text) ||
                                    CBRol.SelectedIndex != -1;

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
                TNombre.Clear();
                TApellido.Clear();
                TNombreUsuario.Clear();
                TClave.Clear();
                TConfirmar.Clear();
                TDni.Clear();
                TCorreo.Clear();
                TTelefono.Clear();
                CBRol.SelectedIndex = -1;
                _ep.Clear();
                TNombre.Focus();
            }
        }

        // BOTON VOLVER

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}