using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetShop.Presentacion.Usuarios
{
    public partial class FormCargaUsuario : Form
    {
        public FormCargaUsuario()
        {
            InitializeComponent();
        }

        private void FormCargaUsuario_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        private void CargarRoles()
        {
            string query = "SELECT id_rol, nombre_rol FROM Rol";

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        CBRol.DataSource = dt;
                        CBRol.ValueMember = "id_rol";
                        CBRol.DisplayMember = "nombre_rol";
                        CBRol.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar roles: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios básicos
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(TClave.Text) ||
                CBRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Nombre, Apellido, Usuario, Contraseña y Rol).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar coincidencia de contraseñas
            if (TClave.Text != TConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"INSERT INTO Usuario (nombre, apellido, nombre_usuario, clave, dni, correo, telefono, estado, fecha_creacion, id_rol)
                            VALUES (@Nombre, @Apellido, @Usuario, @Clave, @Dni, @Correo, @Telefono, 'Activo', GETDATE(), @IdRol)";

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", TNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Apellido", TApellido.Text.Trim());
                        cmd.Parameters.AddWithValue("@Usuario", TNombreUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@Clave", TClave.Text.Trim());

                        // Si los campos opcionales tienen texto se mandan, si no, se inserta DBNull
                        cmd.Parameters.AddWithValue("@Dni", string.IsNullOrWhiteSpace(TDni.Text) ? (object)DBNull.Value : TDni.Text.Trim());
                        cmd.Parameters.AddWithValue("@Correo", string.IsNullOrWhiteSpace(TCorreo.Text) ? (object)DBNull.Value : TCorreo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrWhiteSpace(TTelefono.Text) ? (object)DBNull.Value : TTelefono.Text.Trim());

                        cmd.Parameters.AddWithValue("@IdRol", Convert.ToInt32(CBRol.SelectedValue));

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("El nombre de usuario ingresado ya está en uso. Elija otro.", "Usuario Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el usuario: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BEliminarTodo_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea limpiar todos los campos cargados?",
                "Confirmar Limpieza",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No)
            {
                return;
            }

            TNombre.Clear();
            TApellido.Clear();
            TNombreUsuario.Clear();
            TClave.Clear();
            TConfirmar.Clear();
            TDni.Clear();
            TCorreo.Clear();
            TTelefono.Clear();
            CBRol.SelectedIndex = -1;
            TNombre.Focus();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}