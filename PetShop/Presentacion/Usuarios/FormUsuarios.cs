using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetShop.Presentacion.Usuarios
{
    public partial class FormUsuarios : Form
    {
        private int _idUsuarioLogueado;
        private string _rolUsuarioLogueado;

        // Constructor principal que recibe el ID y el Rol del usuario logueado
        public FormUsuarios(int idUsuarioLogueado, string rolUsuarioLogueado)
        {
            InitializeComponent();
            _idUsuarioLogueado = idUsuarioLogueado;
            _rolUsuarioLogueado = rolUsuarioLogueado ?? "";
        }

        // Constructor por defecto (para evitar errores en el diseñador visual)
        public FormUsuarios() : this(0, "Administrador")
        {
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios(string filtro = "")
        {
            string query = @"SELECT 
                                u.id_usuario AS [ID],
                                u.nombre AS [Nombre],
                                u.apellido AS [Apellido],
                                u.nombre_usuario AS [Usuario],
                                r.nombre_rol AS [Rol],
                                u.estado AS [Estado],
                                u.fecha_creacion AS [Fecha Creación]
                            FROM Usuario u
                            INNER JOIN Rol r ON u.id_rol = r.id_rol
                            WHERE ";

            // Filtrado dinámico según el rol del usuario que está mirando la pantalla
            if (_rolUsuarioLogueado.Equals("Gerente", StringComparison.OrdinalIgnoreCase))
            {
                // El Gerente solo ve a los Vendedores
                query += "r.nombre_rol = 'Vendedor' ";
            }
            else
            {
                // El Administrador ve tanto a Gerentes como a Vendedores
                query += "r.nombre_rol IN ('Vendedor', 'Gerente') ";
            }

            query += @"AND (u.nombre LIKE @Filtro 
                       OR u.apellido LIKE @Filtro 
                       OR u.nombre_usuario LIKE @Filtro)";

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DGVUsuarios.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la lista de usuarios: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 1. BOTÓN NUEVO USUARIO
        private void BNuevoUsuario_Click(object sender, EventArgs e)
        {
            FormCargaUsuario formAlta = new FormCargaUsuario();
            formAlta.ShowDialog();

            CargarUsuarios();
        }

        // 2. BOTÓN MODIFICAR
        private void BModificar_Click(object sender, EventArgs e)
        {
            if (DGVUsuarios.SelectedRows.Count > 0 && DGVUsuarios.CurrentRow != null)
            {
                int idUsuarioSeleccionado = Convert.ToInt32(DGVUsuarios.CurrentRow.Cells["ID"].Value);

                // Validación: Evita modificar la propia cuenta en sesión
                if (idUsuarioSeleccionado == _idUsuarioLogueado)
                {
                    MessageBox.Show("No puede modificar los datos de su propia cuenta activa desde este panel.", "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                FormModificarUsuario formModif = new FormModificarUsuario(idUsuarioSeleccionado);
                formModif.ShowDialog();

                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 3. BOTÓN CAMBIAR ESTADO (ACTIVAR / DESACTIVAR)
        private void BEstado_Click(object sender, EventArgs e)
        {
            if (DGVUsuarios.SelectedRows.Count > 0 && DGVUsuarios.CurrentRow != null)
            {
                int idUsuarioSeleccionado = Convert.ToInt32(DGVUsuarios.CurrentRow.Cells["ID"].Value);

                // Validación: Evita desactivar la propia cuenta en sesión
                if (idUsuarioSeleccionado == _idUsuarioLogueado)
                {
                    MessageBox.Show("No puede desactivar su propio usuario mientras tiene la sesión abierta.", "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string usuarioNombre = DGVUsuarios.CurrentRow.Cells["Usuario"].Value?.ToString() ?? "";
                string estadoTexto = DGVUsuarios.CurrentRow.Cells["Estado"].Value?.ToString().Trim() ?? "";

                bool estadoActual = estadoTexto.Equals("Activo", StringComparison.OrdinalIgnoreCase)
                                 || estadoTexto == "1"
                                 || estadoTexto.Equals("True", StringComparison.OrdinalIgnoreCase);

                int nuevoEstadoBD = estadoActual ? 0 : 1;

                string accionTexto = estadoActual ? "desactivar" : "activar";
                string tituloConfirmacion = estadoActual ? "Confirmar Desactivación" : "Confirmar Activación";

                DialogResult respuesta = MessageBox.Show(
                    $"¿Está seguro de que desea {accionTexto} al usuario '{usuarioNombre}'?",
                    tituloConfirmacion,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    CambiarEstadoUsuario(idUsuarioSeleccionado, nuevoEstadoBD);
                    CargarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CambiarEstadoUsuario(int idUsuario, int nuevoEstado)
        {
            string query = "UPDATE Usuario SET estado = @Estado WHERE id_usuario = @IdUsuario";

            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            string mensaje = (nuevoEstado == 1) ? "activado" : "desactivado";
                            MessageBox.Show($"El usuario ha sido {mensaje} con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el estado: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 4. BOTÓN VOLVER
        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarUsuarios(TBuscar.Text.Trim());
        }

        // Evento que actualiza dinámicamente el texto del botón BEstado al seleccionar una fila
        private void DGVUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVUsuarios.SelectedRows.Count > 0 && DGVUsuarios.CurrentRow != null)
            {
                object valorEstado = DGVUsuarios.CurrentRow.Cells["Estado"].Value;

                if (valorEstado != null && valorEstado != DBNull.Value)
                {
                    string estadoTexto = valorEstado.ToString().Trim();

                    bool estaActivo = estadoTexto.Equals("Activo", StringComparison.OrdinalIgnoreCase)
                                   || estadoTexto == "1"
                                   || estadoTexto.Equals("True", StringComparison.OrdinalIgnoreCase);

                    BEstado.Text = estaActivo ? "Desactivar" : "Activar";
                }
            }
        }
    }
}