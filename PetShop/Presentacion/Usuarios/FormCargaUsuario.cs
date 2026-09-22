using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
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
            // 1. Ocultar caracteres de las contraseñas por defecto
            TClave.UseSystemPasswordChar = true;
            TConfirmar.UseSystemPasswordChar = true;

            // 2. Configurar ComboBox de roles (bloquea la edición manual)
            CBRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarRoles();

            // 3. Vincular eventos KeyPress para filtrado de datos en tiempo real
            TNombre.KeyPress += SoloLetras_KeyPress;
            TApellido.KeyPress += SoloLetras_KeyPress;
            TDni.KeyPress += SoloNumeros_KeyPress;
            TTelefono.KeyPress += SoloNumeros_KeyPress;
        }

        private void CargarRoles()
        {
            string query = "SELECT id_rol, nombre_rol FROM Rol";

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
            // Permite solo letras, espacios y teclas de control (Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Método auxiliar para validar correo electrónico
        private bool EsCorreoValido(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo)) return true; // Si está vacío pasa 
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }


        private void BVerClave_Click(object sender, EventArgs e)
        {
            bool estaEnmascarado = TClave.UseSystemPasswordChar;

            TClave.UseSystemPasswordChar = !estaEnmascarado;
            TConfirmar.UseSystemPasswordChar = !estaEnmascarado;

            if (sender is Button boton)
            {
                boton.Text = estaEnmascarado ? "👁‍🗨" : "👁";
            }
        }

        private void BVerConfirmar_Click(object sender, EventArgs e)
        {
            bool estaEnmascarado = TConfirmar.UseSystemPasswordChar;
            TConfirmar.UseSystemPasswordChar = !estaEnmascarado;
            BVerConfirmar.Text = estaEnmascarado ? "👁‍🗨" : "👁";
        }


        private void BGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validar campos obligatorios básicos
            if (string.IsNullOrWhiteSpace(TNombre.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(TClave.Text) ||
                CBRol.SelectedIndex == -1 ||
                CBRol.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Nombre, Apellido, Usuario, Contraseña y Rol).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar longitud mínima de la contraseña
            if (TClave.Text.Trim().Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TClave.Focus();
                return;
            }

            // 3. Validar coincidencia de contraseñas
            if (TClave.Text != TConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TConfirmar.Focus();
                return;
            }

            // 4. Validar formato de correo electrónico
            if (!EsCorreoValido(TCorreo.Text.Trim()))
            {
                MessageBox.Show("El formato del correo electrónico ingresado no es válido (ejemplo: usuario@correo.com).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TCorreo.Focus();
                return;
            }

            // 5. Validar formato de DNI (opcional pero con longitud válida)
            if (!string.IsNullOrWhiteSpace(TDni.Text) && (TDni.Text.Trim().Length < 7 || TDni.Text.Trim().Length > 8))
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 dígitos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TDni.Focus();
                return;
            }

            // 6. Validar formato de Teléfono (opcional)
            if (!string.IsNullOrWhiteSpace(TTelefono.Text) && TTelefono.Text.Trim().Length < 8)
            {
                MessageBox.Show("El número de teléfono ingresado es demasiado corto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TTelefono.Focus();
                return;
            }

            // 7. Validar conversión correcta del IdRol seleccionado
            if (!int.TryParse(CBRol.SelectedValue.ToString(), out int idRol))
            {
                MessageBox.Show("Seleccione un rol válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- INSERCIÓN EN LA BASE DE DATOS ---
            string query = @"INSERT INTO Usuario (nombre, apellido, nombre_usuario, clave, dni, correo, telefono, estado, fecha_creacion, id_rol) 
                            VALUES (@Nombre, @Apellido, @Usuario, @Clave, @Dni, @Correo, @Telefono, 1, GETDATE(), @IdRol)";

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

                        // Campos opcionales guardados como DBNull si están vacíos
                        cmd.Parameters.AddWithValue("@Dni", string.IsNullOrWhiteSpace(TDni.Text) ? (object)DBNull.Value : TDni.Text.Trim());
                        cmd.Parameters.AddWithValue("@Correo", string.IsNullOrWhiteSpace(TCorreo.Text) ? (object)DBNull.Value : TCorreo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrWhiteSpace(TTelefono.Text) ? (object)DBNull.Value : TTelefono.Text.Trim());

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
            // Comprobar si hay algún dato cargado antes de preguntar
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
                TNombre.Focus();
            }
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}