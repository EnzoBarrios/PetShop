using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PetShop.Presentacion.Usuarios
{
    public partial class FormCargaUsuario : Form
    {
        private ErrorProvider ep = new ErrorProvider();

        public FormCargaUsuario()
        {
            InitializeComponent();
        }

        private void FormCargaUsuario_Load(object sender, EventArgs e)
        {
            // Configuración visual del ErrorProvider (estático, ícono de advertencia)
            ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ep.Icon = System.Drawing.SystemIcons.Warning;

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
            // Filtra para excluir Administrador
            string query = "SELECT id_rol, nombre_rol FROM Rol WHERE nombre_rol <> 'Administrador'";

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        CBRol.DataSource = null;
                        CBRol.DisplayMember = "nombre_rol";
                        CBRol.ValueMember = "id_rol";
                        CBRol.DataSource = dt;
                    }
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
            ep.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(TNombre.Text))
            {
                ep.SetError(TNombre, "El nombre es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(TApellido.Text))
            {
                ep.SetError(TApellido, "El apellido es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(TNombreUsuario.Text))
            {
                ep.SetError(TNombreUsuario, "El nombre de usuario es obligatorio.");
                esValido = false;
            }
            else if (TNombreUsuario.Text.Trim().Length < 4)
            {
                ep.SetError(TNombreUsuario, "El usuario debe tener al menos 4 caracteres.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(TClave.Text))
            {
                ep.SetError(TClave, "La contraseña es obligatoria.");
                esValido = false;
            }
            else if (TClave.Text.Trim().Length < 6)
            {
                ep.SetError(TClave, "La contraseña debe tener al menos 6 caracteres.");
                esValido = false;
            }

            if (TConfirmar.Text != TClave.Text)
            {
                ep.SetError(TConfirmar, "Las contraseñas no coinciden.");
                esValido = false;
            }

            if (!EsCorreoValido(TCorreo.Text.Trim()))
            {
                ep.SetError(TCorreo, "El formato del correo electrónico no es válido.");
                esValido = false;
            }

            if (!string.IsNullOrWhiteSpace(TDni.Text) && (TDni.Text.Trim().Length < 7 || TDni.Text.Trim().Length > 8))
            {
                ep.SetError(TDni, "El DNI debe tener entre 7 y 8 dígitos.");
                esValido = false;
            }

            if (!string.IsNullOrWhiteSpace(TTelefono.Text) && TTelefono.Text.Trim().Length < 8)
            {
                ep.SetError(TTelefono, "El teléfono debe tener al menos 8 dígitos.");
                esValido = false;
            }

            if (CBRol.SelectedIndex == -1 || CBRol.SelectedValue == null)
            {
                ep.SetError(CBRol, "Debe seleccionar un rol.");
                esValido = false;
            }

            return esValido;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones locales del formulario
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

            string nombreUsuario = TNombreUsuario.Text.Trim();

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();

                    // 2. Verificación de Nombre de Usuario duplicado
                    string queryUsuarioExiste = "SELECT COUNT(1) FROM Usuario WHERE LOWER(nombre_usuario) = LOWER(@Usuario)";
                    using (SqlCommand cmdUsuario = new SqlCommand(queryUsuarioExiste, con))
                    {
                        cmdUsuario.Parameters.AddWithValue("@Usuario", nombreUsuario);
                        if (Convert.ToInt32(cmdUsuario.ExecuteScalar()) > 0)
                        {
                            ep.SetError(TNombreUsuario, "Este nombre de usuario ya está en uso.");
                            MessageBox.Show("El nombre de usuario ingresado ya está registrado. Elija otro.", "Usuario Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }

                    // 3. Verificación de DNI duplicado (solo si se ingresó un DNI)
                    if (!string.IsNullOrWhiteSpace(TDni.Text))
                    {
                        string queryDniExiste = "SELECT COUNT(1) FROM Usuario WHERE dni = @Dni";
                        using (SqlCommand cmdDni = new SqlCommand(queryDniExiste, con))
                        {
                            cmdDni.Parameters.AddWithValue("@Dni", TDni.Text.Trim());
                            if (Convert.ToInt32(cmdDni.ExecuteScalar()) > 0)
                            {
                                ep.SetError(TDni, "Este DNI ya pertenece a otro usuario.");
                                MessageBox.Show("El DNI ingresado ya está registrado.", "DNI Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }
                        }
                    }

                    // 4. Verificación de Correo duplicado (solo si se ingresó un correo)
                    if (!string.IsNullOrWhiteSpace(TCorreo.Text))
                    {
                        string queryCorreoExiste = "SELECT COUNT(1) FROM Usuario WHERE LOWER(correo) = LOWER(@Correo)";
                        using (SqlCommand cmdCorreo = new SqlCommand(queryCorreoExiste, con))
                        {
                            cmdCorreo.Parameters.AddWithValue("@Correo", TCorreo.Text.Trim());
                            if (Convert.ToInt32(cmdCorreo.ExecuteScalar()) > 0)
                            {
                                ep.SetError(TCorreo, "Este correo ya pertenece a otro usuario.");
                                MessageBox.Show("El correo electrónico ingresado ya está registrado.", "Correo Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }
                        }
                    }

                    // 5. Inserción en la base de datos
                    string queryInsert = @"INSERT INTO Usuario (nombre, apellido, nombre_usuario, clave, dni, correo, telefono, estado, fecha_creacion, id_rol) 
                                 VALUES (@Nombre, @Apellido, @Usuario, @Clave, @Dni, @Correo, @Telefono, 1, GETDATE(), @IdRol)";

                    using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", TNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Apellido", TApellido.Text.Trim());
                        cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);
                        cmd.Parameters.AddWithValue("@Clave", TClave.Text.Trim());

                        // ACÁ VAN LOS CAMPOS OPCIONALES CON DBNull.Value:
                        cmd.Parameters.Add("@Dni", SqlDbType.VarChar).Value = string.IsNullOrWhiteSpace(TDni.Text) ? (object)DBNull.Value : TDni.Text.Trim();
                        cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = string.IsNullOrWhiteSpace(TCorreo.Text) ? (object)DBNull.Value : TCorreo.Text.Trim();
                        cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = string.IsNullOrWhiteSpace(TTelefono.Text) ? (object)DBNull.Value : TTelefono.Text.Trim();

                        cmd.Parameters.AddWithValue("@IdRol", idRol);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el usuario en la base de datos: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BEliminarTodo_Click(object sender, EventArgs e)
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
                ep.Clear();
                TNombre.Focus();
            }
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}