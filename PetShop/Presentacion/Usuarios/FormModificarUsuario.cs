using System;
using System.Data;
using System.Data.SqlClient;
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

        // Constructor por defecto prevenido para evitar ID = 0
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

            CBRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CBEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            CargarRoles();
            CargarEstados();
            CargarDatosUsuario();
        }

        private void CargarRoles()
        {
            // Usamos DISTINCT para garantizar que la BD no devuelva roles repetidos
            string query = "SELECT DISTINCT id_rol, nombre_rol FROM Rol";

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // 1. Limpieza total del control antes de bindear
                        CBRol.DataSource = null;
                        CBRol.Items.Clear();

                        // 2. Asignar las propiedades de texto y valor PRIMERO
                        CBRol.DisplayMember = "nombre_rol";
                        CBRol.ValueMember = "id_rol";

                        // 3. Asignar la tabla de datos
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
            // Limpia la colección para evitar que se dupliquen "Activo" e "Inactivo"
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

                                // Corrección en la selección del Estado
                                string estadoBD = reader["estado"].ToString();
                                CBEstado.Text = estadoBD;

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
            bool confirmacionEscrita = !string.IsNullOrWhiteSpace(TConfirmar.Text);

            if (contrasenaEscrita || confirmacionEscrita)
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
                        cmd.Parameters.AddWithValue("@estado", CBEstado.Text.Trim());
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

        private void LTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}