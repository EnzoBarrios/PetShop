using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetShop
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

        public FormModificarUsuario()
        {
            InitializeComponent();
        }

        private void FormModificarUsuario_Load(object sender, EventArgs e)
        {
            CBRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CBEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            // 1. Cargar las opciones de los desplegables
            CargarRoles();
            CargarEstados();

            // 2. Llenar los campos con los datos del usuario (al final)
            CargarDatosUsuario();
        }

        private void CargarRoles()
        {
            string query = "SELECT id_rol, nombre_rol FROM Rol";
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    CBRol.DataSource = dt;
                    CBRol.DisplayMember = "nombre_rol";
                    CBRol.ValueMember = "id_rol";
                }
            }
        }

        private void CargarEstados()
        {
            // Ajusta los valores de acuerdo a como guardes el Estado en tu BD (ej. Activo/Inactivo)
            CBEstado.Items.Clear();
            CBEstado.Items.Add("Activo");
            CBEstado.Items.Add("Inactivo");
        }

        private void CargarDatosUsuario()
        {
            string query = "SELECT nombre, apellido, nombre_usuario, id_rol, estado, fecha_creacion FROM Usuario WHERE id_usuario = @id";

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
                                CBRol.SelectedValue = Convert.ToInt32(reader["id_rol"]);
                                CBEstado.SelectedItem = reader["estado"].ToString();

                                if (reader["fecha_creacion"] != DBNull.Value)
                                {
                                    DateTime fecha = Convert.ToDateTime(reader["fecha_creacion"]);
                                    LFechaCreacion.Text = fecha.ToString("dd 'de' MMMM 'de' yyyy");
                                }
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

            bool contrasenaEscrita = !string.IsNullOrWhiteSpace(TClave.Text);

            if (contrasenaEscrita)
            {
                if (TClave.Text.Length < 6)
                {
                    ep.SetError(TClave, "La contraseña debe tener al menos 6 caracteres.");
                    esValido = false;
                }

                if (TConfirmar.Text != TClave.Text)
                {
                    ep.SetError(TConfirmar, "Las contraseñas no coinciden.");
                    esValido = false;
                }
            }

            if (CBRol.SelectedIndex == -1 || CBRol.SelectedItem == null)
            {
                ep.SetError(CBRol, "Debe seleccionar un rol.");
                esValido = false;
            }

            if (CBEstado.SelectedIndex == -1 || CBEstado.SelectedItem == null)
            {
                ep.SetError(CBEstado, "Debe seleccionar un estado.");
                esValido = false;
            }

            return esValido;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario()) return;

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
                    this.Close();
                }
            }
        }

        private bool GuardarCambios()
        {
            bool contrasenaEscrita = !string.IsNullOrWhiteSpace(TClave.Text);

            // Construir la consulta según si el usuario ingresó o no una nueva contraseña
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
                        cmd.Parameters.AddWithValue("@id_rol", CBRol.SelectedValue);
                        cmd.Parameters.AddWithValue("@estado", CBEstado.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@id", _idUsuario);

                        if (contrasenaEscrita)
                        {
                            cmd.Parameters.AddWithValue("@clave", TClave.Text.Trim());
                        }

                        cmd.ExecuteNonQuery();
                        return true;
                    }
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
                "¿Desea blanquear todos los campos del formulario?",
                "Limpiar campos",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            TNombre.Clear();
            TApellido.Clear();
            TNombreUsuario.Clear();
            TClave.Clear();
            TConfirmar.Clear();

            CBRol.SelectedIndex = -1;
            CBEstado.SelectedIndex = -1;

            ep.Clear();
            TNombre.Focus();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}