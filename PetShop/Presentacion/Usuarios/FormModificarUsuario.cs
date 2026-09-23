using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PetShop.Negocio;
using PetShop.Entidades;

namespace PetShop.Presentacion.Usuarios
{
    public partial class FormModificarUsuario : Form
    {
        // Campo para almacenar el ID del usuario que se va a modificar
        private readonly int _idUsuario;
        private readonly ErrorProvider _ep = new ErrorProvider();
        private readonly CN_Usuario _cnUsuario = new CN_Usuario();
        private readonly CN_Rol _cnRol = new CN_Rol();

        public FormModificarUsuario(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
        }

        public FormModificarUsuario() : this(0)
        {
        }

        private void FormModificarUsuario_Load(object sender, EventArgs e)
        {
            if (_idUsuario <= 0)
            {
                MessageBox.Show("No se seleccionó un usuario válido para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            // Configuración visual del ErrorProvider
            _ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _ep.Icon = System.Drawing.SystemIcons.Warning;

            TClave.UseSystemPasswordChar = true;
            TConfirmar.UseSystemPasswordChar = true;

            CBRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CBEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            // Oscurecer y proteger campos personales (DNI, Teléfono, Correo)
            BloquearCamposPersonales();

            TNombre.KeyPress += SoloLetras_KeyPress;
            TApellido.KeyPress += SoloLetras_KeyPress;

            CargarRoles();
            CargarEstados();
            CargarDatosUsuario();
        }

        private void BloquearCamposPersonales()
        {
            TextBox[] camposBloqueados = { TDni, TTelefono, TCorreo };

            foreach (TextBox txt in camposBloqueados)
            {
                txt.ReadOnly = true;
                txt.TabStop = false;
                txt.BackColor = System.Drawing.Color.FromArgb(220, 224, 230);
                txt.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            }
        }

        private void CargarRoles()
        {
            try
            {
                var roles = _cnRol.ListarRoles();
                roles.RemoveAll(r => r.NombreRol.Equals("Administrador", StringComparison.OrdinalIgnoreCase));

                CBRol.DataSource = null;
                CBRol.Items.Clear();
                CBRol.DisplayMember = "NombreRol";
                CBRol.ValueMember = "IdRol";
                CBRol.DataSource = roles;
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstados()
        {
            CBEstado.Items.Clear();
            CBEstado.Items.Add("Activo");
            CBEstado.Items.Add("Inactivo");
        }

        private void CargarDatosUsuario()
        {
            try
            {
                Usuario usuario = _cnUsuario.ObtenerPorId(_idUsuario);

                if (usuario != null)
                {
                    TNombre.Text = usuario.Nombre;
                    TApellido.Text = usuario.Apellido;
                    TNombreUsuario.Text = usuario.NombreUsuario;

                    TDni.Text = usuario.Dni;
                    TCorreo.Text = usuario.Correo;
                    TTelefono.Text = usuario.Telefono;

                    CBRol.SelectedValue = usuario.IdRol;
                    CBEstado.Text = usuario.Estado ? "Activo" : "Inactivo";

                    LFechaCreacion.Text = "Fecha de creación: " + usuario.FechaCreacion.ToString("dd 'de' MMMM 'de' yyyy");
                }
                else
                {
                    MessageBox.Show("No se encontraron los datos del usuario en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del usuario: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
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
                _ep.SetError(TNombreUsuario, "Debe tener al menos 4 caracteres.");
                esValido = false;
            }

            // La clave solo se valida si el administrador escribió algo para cambiarla
            bool contrasenaEscrita = !string.IsNullOrWhiteSpace(TClave.Text);
            bool confirmacionEscrita = !string.IsNullOrWhiteSpace(TConfirmar.Text);

            if (contrasenaEscrita || confirmacionEscrita)
            {
                if (TClave.Text.Trim().Length < 6)
                {
                    _ep.SetError(TClave, "La nueva contraseña debe tener al menos 6 caracteres.");
                    esValido = false;
                }

                if (TConfirmar.Text != TClave.Text)
                {
                    _ep.SetError(TConfirmar, "Las contraseñas no coinciden.");
                    esValido = false;
                }
            }

            if (CBRol.SelectedIndex == -1 || CBRol.SelectedValue == null)
            {
                _ep.SetError(CBRol, "Debe seleccionar un rol.");
                esValido = false;
            }

            if (CBEstado.SelectedIndex == -1 || string.IsNullOrWhiteSpace(CBEstado.Text))
            {
                _ep.SetError(CBEstado, "Debe seleccionar un estado.");
                esValido = false;
            }

            return esValido;
        }

        // BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                MessageBox.Show("Por favor, verifique los campos marcados con advertencias.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea guardar los cambios del usuario?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes) return;

            bool actualizarClave = !string.IsNullOrWhiteSpace(TClave.Text);

            Usuario usuarioModificado = new Usuario
            {
                IdUsuario = _idUsuario,
                Nombre = TNombre.Text.Trim(),
                Apellido = TApellido.Text.Trim(),
                NombreUsuario = TNombreUsuario.Text.Trim(),
                Clave = TClave.Text.Trim(),
                IdRol = Convert.ToInt32(CBRol.SelectedValue),
                Estado = CBEstado.Text.Trim().Equals("Activo", StringComparison.OrdinalIgnoreCase)
            };

            bool exito = _cnUsuario.ModificarUsuario(usuarioModificado, actualizarClave, out string mensaje);

            if (exito)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                _ep.SetError(TNombreUsuario, mensaje);
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // BOTON BORRAR
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show(
                "¿Desea restablecer los campos a sus valores originales?",
                "Restablecer campos",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            TClave.Clear();
            TConfirmar.Clear();
            _ep.Clear();
            CargarDatosUsuario();
            TNombre.Focus();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}