using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PetShop.Presentacion.Usuarios
{
    public partial class FormMiPerfil : Form
    {
        private readonly int _idUsuarioActual;
        private readonly ErrorProvider error = new ErrorProvider();

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

            ConfigurarEstiloCamposLectura();
            ConfigurarEstiloBotones();

            CargarDatosPerfil();
            AsignarEventosValidacion();
        }

        private void ConfigurarEstiloCamposLectura()
        {
            // ÚNICAMENTE ROL Y ESTADO EN SOLO LECTURA
            TRol.ReadOnly = true;
            TEstado.ReadOnly = true;

            TRol.TabStop = false;
            TEstado.TabStop = false;

            Color fondoLectura = Color.FromArgb(240, 240, 240);
            TRol.BackColor = fondoLectura;
            TEstado.BackColor = fondoLectura;

            // LOS DEMÁS CAMPOS SE MANTIENEN EDITABLES (ReadOnly = false y fondo blanco)
            TNombreUsuario.ReadOnly = false;
            TNombre.ReadOnly = false;
            TApellido.ReadOnly = false;
            TDni.ReadOnly = false;
            TCorreo.ReadOnly = false;
            TTelefono.ReadOnly = false;

            TNombreUsuario.TabStop = true;
            TNombre.TabStop = true;
            TApellido.TabStop = true;
            TDni.TabStop = true;
            TCorreo.TabStop = true;
            TTelefono.TabStop = true;

            TNombreUsuario.BackColor = Color.White;
            TNombre.BackColor = Color.White;
            TApellido.BackColor = Color.White;
            TDni.BackColor = Color.White;
            TCorreo.BackColor = Color.White;
            TTelefono.BackColor = Color.White;

            TClave.UseSystemPasswordChar = true;
            TConfirmar.UseSystemPasswordChar = true;
        }

        private void ConfigurarEstiloBotones()
        {
            BGuardar.FlatStyle = FlatStyle.Flat;
            BGuardar.BackColor = Color.White;
            BGuardar.ForeColor = Color.FromArgb(20, 80, 20);
            BGuardar.FlatAppearance.BorderSize = 1;
            BGuardar.FlatAppearance.BorderColor = Color.FromArgb(144, 238, 144);
            BGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(144, 238, 144);
            BGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 210, 120);

            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.BackColor = Color.White;
            BVolver.ForeColor = Color.Black;
            BVolver.FlatAppearance.BorderSize = 1;
            BVolver.FlatAppearance.BorderColor = Color.LightGray;
            BVolver.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
        }

        private void AsignarEventosValidacion()
        {
            TCorreo.Validating += TCorreo_Validating;
            TTelefono.Validating += TTelefono_Validating;
            TClave.Validating += TClave_Validating;
            TConfirmar.Validating += TConfirmar_Validating;
        }

        private void CargarDatosPerfil()
        {
            string query = @"SELECT u.nombre, u.apellido, u.nombre_usuario, u.dni, u.correo, u.telefono, u.estado, r.nombre_rol 
                            FROM Usuario u
                            INNER JOIN Rol r ON u.id_rol = r.id_rol
                            WHERE u.id_usuario = @id";

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", _idUsuarioActual);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TNombre.Text = reader["nombre"].ToString();
                                TApellido.Text = reader["apellido"].ToString();
                                TNombreUsuario.Text = reader["nombre_usuario"].ToString();
                                TRol.Text = reader["nombre_rol"].ToString();

                                string estadoValor = reader["estado"].ToString().Trim();
                                if (estadoValor == "1" || estadoValor.Equals("Activo", StringComparison.OrdinalIgnoreCase) || estadoValor.Equals("A", StringComparison.OrdinalIgnoreCase))
                                {
                                    TEstado.Text = "Activo";
                                }
                                else
                                {
                                    TEstado.Text = "Inactivo";
                                }

                                TDni.Text = reader["dni"] != DBNull.Value ? reader["dni"].ToString() : string.Empty;
                                TCorreo.Text = reader["correo"] != DBNull.Value ? reader["correo"].ToString() : string.Empty;
                                TTelefono.Text = reader["telefono"] != DBNull.Value ? reader["telefono"].ToString() : string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron los datos del perfil para el ID: " + _idUsuarioActual, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos del perfil desde la base de datos: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region VALIDACIONES DINÁMICAS (EVENTOS VALIDATING)

        private void TCorreo_Validating(object sender, CancelEventArgs e)
        {
            string correo = TCorreo.Text.Trim();
            if (!string.IsNullOrEmpty(correo))
            {
                string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(correo, patronEmail))
                {
                    error.SetError(TCorreo, "Ingrese un correo electrónico válido (ejemplo@dominio.com).");
                    return;
                }
            }
            error.SetError(TCorreo, string.Empty);
        }

        private void TTelefono_Validating(object sender, CancelEventArgs e)
        {
            string telefono = TTelefono.Text.Trim();
            if (!string.IsNullOrEmpty(telefono))
            {
                if (!Regex.IsMatch(telefono, @"^[0-9+\s\-]+$"))
                {
                    error.SetError(TTelefono, "El teléfono solo debe contener números, espacios o guiones.");
                    return;
                }
            }
            error.SetError(TTelefono, string.Empty);
        }

        private void TClave_Validating(object sender, CancelEventArgs e)
        {
            bool contrasenaEscrita = !string.IsNullOrWhiteSpace(TClave.Text);
            bool confirmacionEscrita = !string.IsNullOrWhiteSpace(TConfirmar.Text);

            if (contrasenaEscrita || confirmacionEscrita)
            {
                if (TClave.Text.Length < 6)
                {
                    error.SetError(TClave, "La contraseña debe tener al menos 6 caracteres.");
                    return;
                }
            }
            error.SetError(TClave, string.Empty);
        }

        private void TConfirmar_Validating(object sender, CancelEventArgs e)
        {
            bool contrasenaEscrita = !string.IsNullOrWhiteSpace(TClave.Text);
            bool confirmacionEscrita = !string.IsNullOrWhiteSpace(TConfirmar.Text);

            if (contrasenaEscrita || confirmacionEscrita)
            {
                if (TConfirmar.Text != TClave.Text)
                {
                    error.SetError(TConfirmar, "Las contraseñas no coinciden.");
                    return;
                }
            }
            error.SetError(TConfirmar, string.Empty);
        }

        #endregion

        private bool ValidarFormulario()
        {
            error.Clear();
            bool esValido = true;

            // Validar Nombre Obligatorio
            if (string.IsNullOrWhiteSpace(TNombre.Text))
            {
                error.SetError(TNombre, "El nombre no puede estar vacío.");
                esValido = false;
            }

            // Validar Apellido Obligatorio
            if (string.IsNullOrWhiteSpace(TApellido.Text))
            {
                error.SetError(TApellido, "El apellido no puede estar vacío.");
                esValido = false;
            }

            // Validar Usuario Obligatorio
            if (string.IsNullOrWhiteSpace(TNombreUsuario.Text))
            {
                error.SetError(TNombreUsuario, "El nombre de usuario no puede estar vacío.");
                esValido = false;
            }

            // Validar Correo (Opcional)
            string correo = TCorreo.Text.Trim();
            if (!string.IsNullOrEmpty(correo))
            {
                string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(correo, patronEmail))
                {
                    error.SetError(TCorreo, "Ingrese un correo electrónico válido.");
                    esValido = false;
                }
            }

            // Validar Teléfono (Opcional)
            string telefono = TTelefono.Text.Trim();
            if (!string.IsNullOrEmpty(telefono))
            {
                if (!Regex.IsMatch(telefono, @"^[0-9+\s\-]+$"))
                {
                    error.SetError(TTelefono, "El teléfono contiene caracteres no válidos.");
                    esValido = false;
                }
            }

            // Validar Contraseña (Solo si decide cambiarla)
            bool contrasenaEscrita = !string.IsNullOrWhiteSpace(TClave.Text);
            bool confirmacionEscrita = !string.IsNullOrWhiteSpace(TConfirmar.Text);

            if (contrasenaEscrita || confirmacionEscrita)
            {
                if (TClave.Text.Length < 6)
                {
                    error.SetError(TClave, "La contraseña debe tener al menos 6 caracteres.");
                    esValido = false;
                }

                if (TConfirmar.Text != TClave.Text)
                {
                    error.SetError(TConfirmar, "Las contraseñas no coinciden.");
                    esValido = false;
                }
            }

            return esValido;
        }

        private void BGuardar_Click(object sender, EventArgs e)
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

            if (confirmacion == DialogResult.Yes)
            {
                if (GuardarPerfil())
                {
                    MessageBox.Show("Perfil actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TClave.Clear();
                    TConfirmar.Clear();
                    error.Clear();
                }
            }
        }

        private bool GuardarPerfil()
        {
            bool cambiarClave = !string.IsNullOrWhiteSpace(TClave.Text);

            string query = @"UPDATE Usuario 
                            SET nombre = @nombre,
                                apellido = @apellido,
                                nombre_usuario = @nombre_usuario,
                                dni = @dni,
                                correo = @correo, 
                                telefono = @telefono";

            if (cambiarClave)
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
                        cmd.Parameters.AddWithValue("@nombre", TNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@apellido", TApellido.Text.Trim());
                        cmd.Parameters.AddWithValue("@nombre_usuario", TNombreUsuario.Text.Trim());

                        cmd.Parameters.AddWithValue("@dni", string.IsNullOrWhiteSpace(TDni.Text)
                            ? (object)DBNull.Value
                            : TDni.Text.Trim());

                        cmd.Parameters.AddWithValue("@correo", string.IsNullOrWhiteSpace(TCorreo.Text)
                            ? (object)DBNull.Value
                            : TCorreo.Text.Trim());

                        cmd.Parameters.AddWithValue("@telefono", string.IsNullOrWhiteSpace(TTelefono.Text)
                            ? (object)DBNull.Value
                            : TTelefono.Text.Trim());

                        cmd.Parameters.AddWithValue("@id", _idUsuarioActual);

                        if (cambiarClave)
                        {
                            cmd.Parameters.AddWithValue("@clave", TClave.Text.Trim());
                        }

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la información del perfil: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void BVerClave_Click(object sender, EventArgs e)
        {
            TClave.UseSystemPasswordChar = !TClave.UseSystemPasswordChar;
        }

        private void BVerConfirmar_Click(object sender, EventArgs e)
        {
            TConfirmar.UseSystemPasswordChar = !TConfirmar.UseSystemPasswordChar;
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}