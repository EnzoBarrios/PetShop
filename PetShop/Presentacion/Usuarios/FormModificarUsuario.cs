using System;
using System.Data;
using System.Data.SqlClient;
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

            // Bloquear todos los campos de datos personales e identificación
            BloquearCamposLectura();

            CargarRoles();
            CargarEstados();
            CargarDatosUsuario();
        }

        private void BloquearCamposLectura()
        {
            // Bloquea e inactiva visualmente los campos que no deben ser modificados
            TextBox[] camposBloqueados = { TNombre, TApellido, TNombreUsuario, TDni, TTelefono, TCorreo};

            foreach (TextBox txt in camposBloqueados)
            {
                txt.ReadOnly = true;
                txt.TabStop = false;
                txt.BackColor = System.Drawing.Color.FromArgb(220, 224, 230);
                txt.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            }

            CBEstado.Enabled = false;
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
            // Limpia advertencias previas
            _ep.Clear();
            bool esValido = true;

            // La contraseña solo se valida si se escribió algo en alguno de los campos de clave
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

            // Validación de Selección de Rol
            if (CBRol.SelectedIndex == -1 || CBRol.SelectedValue == null)
            {
                _ep.SetError(CBRol, "Debe seleccionar un rol.");
                esValido = false;
            }

            // Validación de Selección de Estado
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

        private bool GuardarCambios()
        {
            bool contrasenaEscrita = !string.IsNullOrWhiteSpace(TClave.Text);

            // Únicamente actualizamos Rol, Estado y opcionalmente Clave
            string query = @"UPDATE Usuario 
                            SET id_rol = @id_rol, 
                                estado = @estado";

            if (contrasenaEscrita)
            {
                query += ", clave = @clave";
            }

            query += " WHERE id_usuario = @id";

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id_rol", Convert.ToInt32(CBRol.SelectedValue));

                        int estadoBD = CBEstado.Text.Trim().Equals("Activo", StringComparison.OrdinalIgnoreCase) ? 1 : 0;
                        cmd.Parameters.AddWithValue("@estado", estadoBD);

                        cmd.Parameters.AddWithValue("@id", _idUsuario);

                        if (contrasenaEscrita)
                        {
                            cmd.Parameters.AddWithValue("@clave", TClave.Text.Trim());
                        }

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el usuario a modificar en la base de datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el usuario: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}