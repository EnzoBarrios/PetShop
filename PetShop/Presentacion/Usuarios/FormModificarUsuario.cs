using System;
using System.Windows.Forms;
using PetShop.Negocio;
using PetShop.Entidades;
using System.Collections.Generic;

namespace PetShop.Presentacion.Usuarios
{
    public partial class FormModificarUsuario : Form
    {
        // Campo para almacenar el ID del usuario que se va a modificar
        private readonly int _idUsuario;
        private readonly string _rolOperadorActual;
        private readonly ErrorProvider _ep = new ErrorProvider();
        private readonly CN_Usuario _cnUsuario = new CN_Usuario();
        private readonly CN_Rol _cnRol = new CN_Rol();

        public FormModificarUsuario(int idUsuario, string rolOperadorActual = CN_Rol.ROL_ADMINISTRADOR)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            _rolOperadorActual = rolOperadorActual;
        }

        private void FormModificarUsuario_Load(object sender, EventArgs e)
        {
            if (_idUsuario <= 0)
            {
                MessageBox.Show("No se seleccionó un usuario válido para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            // Bloquear todos los campos de datos personales e identificación
            ConfigurarControles();
            BloquearCamposLectura();
            CargarRoles();
            CargarEstados();
            CargarDatosUsuario();
        }

        private void ConfigurarControles()
        {
            // Configuración visual del ErrorProvider
            _ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _ep.Icon = System.Drawing.SystemIcons.Warning;

            txtClave.UseSystemPasswordChar = true;
            txtConfirmar.UseSystemPasswordChar = true;

            cbxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BloquearCamposLectura()
        {
            // Bloquea e inactiva visualmente los campos que no deben ser modificados
            TextBox[] camposBloqueados = { txtNombre, txtApellido, txtNombreUsuario, txtDni, txtTelefono, txtCorreo};

            foreach (TextBox txt in camposBloqueados)
            {
                txt.ReadOnly = true;
                txt.TabStop = false;
                txt.BackColor = System.Drawing.Color.FromArgb(220, 224, 230);
                txt.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            }
        }

        private void CargarRoles()
        {
            try
            {
                List<Rol> rolesPermitidos = _cnRol.ObtenerRolesPermitidos(_rolOperadorActual);

                cbxRol.DataSource = null;
                cbxRol.Items.Clear();
                cbxRol.DisplayMember = nameof(Rol.NombreRol);
                cbxRol.ValueMember = nameof(Rol.IdRol);
                cbxRol.DataSource = rolesPermitidos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message, 
                    "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstados()
        {
            cbxEstado.Items.Clear();
            cbxEstado.Items.Add("Activo");
            cbxEstado.Items.Add("Inactivo");
        }

        private void CargarDatosUsuario()
        {
            try
            {
                Usuario usuario = _cnUsuario.ObtenerPorId(_idUsuario);

                if (usuario == null)
                {
                    MessageBox.Show("No se encontró el registro en la base de datos.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

                    txtNombre.Text = usuario.Nombre;
                    txtApellido.Text = usuario.Apellido;
                    txtNombreUsuario.Text = usuario.NombreUsuario;

                    txtDni.Text = usuario.Dni ?? string.Empty;
                    txtCorreo.Text = usuario.Correo ?? string.Empty;
                    txtTelefono.Text = usuario.Telefono ?? string.Empty;

                if (usuario.Rol != null)
                {
                    cbxRol.SelectedValue = usuario.Rol.IdRol;
                }

                    cbxEstado.Text = usuario.Estado ? "Activo" : "Inactivo";
                    lblFechaCreacion.Text = "Fecha de creación: " + usuario.FechaCreacion.ToString("dd 'de' MMMM 'de' yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del usuario: " + ex.Message, 
                    "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
 
        private void CambiarVisibilidadClave(TextBox claveTexto, Button botonCambiar)
        {
            claveTexto.UseSystemPasswordChar = !claveTexto.UseSystemPasswordChar;
            botonCambiar.Text = claveTexto.UseSystemPasswordChar ? "👁" : "👁‍🗨";
        }

        // BOTONES PARA MOSTRAR/OCULTAR CONTRASEÑA
        private void BtnVerClave_Click(object sender, EventArgs e)
        {
            CambiarVisibilidadClave(txtClave, (Button)sender);
        }

        private void BtnVerConfirmar_Click(object sender, EventArgs e)
        {
            CambiarVisibilidadClave(txtConfirmar, (Button)sender);
        }

        private bool ValidarFormulario()
        {
            // Limpia advertencias previas
            _ep.Clear();
            bool esValido = true;

            // La contraseña solo se valida si se escribió algo en alguno de los campos de clave
            bool ingresoClave = !string.IsNullOrWhiteSpace(txtClave.Text);
            bool ingresoConfirmacion = !string.IsNullOrWhiteSpace(txtConfirmar.Text);

            if (ingresoClave || ingresoConfirmacion)
            {
                if (txtClave.Text.Trim().Length < 6)
                {
                    _ep.SetError(txtClave, "La nueva contraseña debe tener al menos 6 caracteres.");
                    esValido = false;
                }

                if (txtConfirmar.Text != txtClave.Text)
                {
                    _ep.SetError(txtConfirmar, "Las contraseñas no coinciden.");
                    esValido = false;
                }
            }

            // Validación de Selección de Rol
            if (cbxRol.SelectedIndex == -1 || cbxRol.SelectedValue == null)
            {
                _ep.SetError(cbxRol, "Debe seleccionar un rol.");
                esValido = false;
            }

            // Validación de Selección de Estado
            if (cbxEstado.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                _ep.SetError(cbxEstado, "Debe seleccionar un estado.");
                esValido = false;
            }

            return esValido;
        }

        // BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                MessageBox.Show("Por favor, verifique los campos marcados con advertencias.", 
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea guardar los cambios del usuario?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion != DialogResult.Yes) return;

            bool actualizarClave = !string.IsNullOrWhiteSpace(txtClave.Text);
            string claveNueva = txtClave.Text.Trim();

            Usuario usuarioModificado = new Usuario
            {
                IdUsuario = _idUsuario,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                NombreUsuario = txtNombreUsuario.Text.Trim(),
                Dni = string.IsNullOrWhiteSpace(txtDni.Text) ? null : txtDni.Text.Trim(),
                Correo = string.IsNullOrWhiteSpace(txtCorreo.Text) ? null : txtCorreo.Text.Trim(), 
                Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                Estado = cbxEstado.Text.Trim().Equals("Activo", StringComparison.OrdinalIgnoreCase),
                Rol = new Rol { IdRol = Convert.ToInt32(cbxRol.SelectedValue) }
            };

            bool exito = _cnUsuario.ModificarUsuario(usuarioModificado, actualizarClave, claveNueva,out string mensaje);

            if (exito)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                _ep.SetError(txtNombreUsuario, mensaje);
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
            txtClave.Clear();
            txtConfirmar.Clear();
            _ep.Clear();
            CargarDatosUsuario();
        }

        // BOTON VOLVER
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}