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
            AsignarEventosValidacion();
            CargarDatosPerfil();
        }

        private void ConfigurarEstiloCamposLectura()
        {
            TNombreUsuario.ReadOnly = true;
            TRol.ReadOnly = true;
            TEstado.ReadOnly = true;
            TNombre.ReadOnly = true;
            TApellido.ReadOnly = true;
            TDni.ReadOnly = true;

            TNombreUsuario.TabStop = false;
            TRol.TabStop = false;
            TEstado.TabStop = false;
            TNombre.TabStop = false;
            TApellido.TabStop = false;
            TDni.TabStop = false;

            Color fondoLectura = Color.FromArgb(240, 240, 240);
            TNombreUsuario.BackColor = fondoLectura;
            TRol.BackColor = fondoLectura;
            TEstado.BackColor = fondoLectura;
            TNombre.BackColor = fondoLectura;
            TApellido.BackColor = fondoLectura;
            TDni.BackColor = fondoLectura;

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
                                TEstado.Text = reader["estado"].ToString();
                                TRol.Text = reader["nombre_rol"].ToString();

                                TDni.Text = reader["dni"] != DBNull.Value ? reader["dni"].ToString() : string.Empty;
                                TCorreo.Text = reader["correo"] != DBNull.Value ? reader["correo"].ToString() : string.Empty;
                                TTelefono.Text = reader["telefono"] != DBNull.Value ? reader["telefono"].ToString() : string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron los datos del perfil.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            string telefono = TTelefono.Text.Trim();
            if (!string.IsNullOrEmpty(telefono))
            {
                if (!Regex.IsMatch(telefono, @"^[0-9+\s\-]+$"))
                {
                    error.SetError(TTelefono, "El teléfono contiene caracteres no válidos.");
                    esValido = false;
                }
            }

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
                            SET correo = @correo, 
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

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}