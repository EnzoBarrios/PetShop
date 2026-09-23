using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PetShop.Presentacion.Usuarios
{
    public partial class FormModificarUsuario : Form
    {
        private int _idUsuario;
        private ErrorProvider ep = new ErrorProvider();

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
            ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ep.Icon = System.Drawing.SystemIcons.Warning;

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
            string query = "SELECT DISTINCT id_rol, nombre_rol FROM Rol WHERE nombre_rol <> 'Administrador'";

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
                        CBRol.Items.Clear();

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

        private void CargarEstados()
        {
            CBEstado.Items.Clear();
            CBEstado.Items.Add("Activo");
            CBEstado.Items.Add("Inactivo");
        }

        private void CargarDatosUsuario()
        {
            string query = @"SELECT nombre, apellido, nombre_usuario, dni, correo, telefono, id_rol, estado, fecha_creacion 
                            FROM Usuario WHERE id_usuario = @id";

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", _idUsuario);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TNombre.Text = reader["nombre"].ToString();
                                TApellido.Text = reader["apellido"].ToString();
                                TNombreUsuario.Text = reader["nombre_usuario"].ToString();

                                TDni.Text = reader["dni"] != DBNull.Value ? reader["dni"].ToString() : "";
                                TCorreo.Text = reader["correo"] != DBNull.Value ? reader["correo"].ToString() : "";
                                TTelefono.Text = reader["telefono"] != DBNull.Value ? reader["telefono"].ToString() : "";

                                CBRol.SelectedValue = Convert.ToInt32(reader["id_rol"]);

                                string estadoBD = reader["estado"].ToString().Trim();
                                CBEstado.Text = estadoBD.Equals("1") || estadoBD.Equals("True") || estadoBD.Equals("Activo", StringComparison.OrdinalIgnoreCase) ? "Activo" : "Inactivo";

                                if (reader["fecha_creacion"] != DBNull.Value)
                                {
                                    DateTime fecha = Convert.ToDateTime(reader["fecha_creacion"]);
                                    LFechaCreacion.Text = "Fecha de creación: " + fecha.ToString("dd 'de' MMMM 'de' yyyy");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron los datos del usuario en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos del usuario: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ep.SetError(TNombreUsuario, "Debe tener al menos 4 caracteres.");
                esValido = false;
            }

            // La clave solo se valida si el administrador escribió algo para cambiarla
            bool contrasenaEscrita = !string.IsNullOrWhiteSpace(TClave.Text);
            bool confirmacionEscrita = !string.IsNullOrWhiteSpace(TConfirmar.Text);

            if (contrasenaEscrita || confirmacionEscrita)
            {
                if (TClave.Text.Trim().Length < 6)
                {
                    ep.SetError(TClave, "La nueva contraseña debe tener al menos 6 caracteres.");
                    esValido = false;
                }

                if (TConfirmar.Text != TClave.Text)
                {
                    ep.SetError(TConfirmar, "Las contraseñas no coinciden.");
                    esValido = false;
                }
            }

            if (CBRol.SelectedIndex == -1 || CBRol.SelectedValue == null)
            {
                ep.SetError(CBRol, "Debe seleccionar un rol.");
                esValido = false;
            }

            if (CBEstado.SelectedIndex == -1 || string.IsNullOrWhiteSpace(CBEstado.Text))
            {
                ep.SetError(CBEstado, "Debe seleccionar un estado.");
                esValido = false;
            }

            return esValido;
        }

        private void BGuardar_Click(object sender, EventArgs e)
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

            if (confirmacion == DialogResult.Yes)
            {
                if (GuardarCambios())
                {
                    MessageBox.Show("Usuario modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private bool GuardarCambios()
        {
            bool contrasenaEscrita = !string.IsNullOrWhiteSpace(TClave.Text);

            string query = @"UPDATE Usuario 
                            SET nombre = @nombre, 
                                apellido = @apellido, 
                                nombre_usuario = @nombre_usuario, 
                                id_rol = @id_rol, 
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
                        cmd.Parameters.AddWithValue("@nombre", TNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@apellido", TApellido.Text.Trim());
                        cmd.Parameters.AddWithValue("@nombre_usuario", TNombreUsuario.Text.Trim());
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
                catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
                {
                    ep.SetError(TNombreUsuario, "Este nombre de usuario ya está registrado.");
                    MessageBox.Show("El nombre de usuario ingresado ya pertenece a otro registro.", "Usuario Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el usuario: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        private void BEliminarTodo_Click(object sender, EventArgs e)
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
            ep.Clear();
            CargarDatosUsuario();
            TNombre.Focus();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}