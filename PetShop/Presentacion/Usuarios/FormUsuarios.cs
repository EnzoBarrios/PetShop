using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetShop.Presentacion.Usuarios
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
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
                            WHERE u.nombre LIKE @Filtro 
                               OR u.apellido LIKE @Filtro 
                               OR u.nombre_usuario LIKE @Filtro";

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
            if (DGVUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(DGVUsuarios.CurrentRow.Cells["ID"].Value);

                FormModificarUsuario formModif = new FormModificarUsuario(idUsuario);
                formModif.ShowDialog();

                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BEstado_Click(object sender, EventArgs e)
        {
            if (DGVUsuarios.SelectedRows.Count > 0 && DGVUsuarios.CurrentRow != null)
            {
                int idUsuario = Convert.ToInt32(DGVUsuarios.CurrentRow.Cells["ID"].Value);
                string usuarioNombre = DGVUsuarios.CurrentRow.Cells["Usuario"].Value?.ToString() ?? "";
                string estadoTexto = DGVUsuarios.CurrentRow.Cells["Estado"].Value?.ToString().Trim() ?? "";

                // 1. Obtener el estado actual de forma segura (verifica texto o número sin romper por conversión)
                bool estadoActual = estadoTexto.Equals("Activo", StringComparison.OrdinalIgnoreCase)
                                 || estadoTexto == "1"
                                 || estadoTexto.Equals("True", StringComparison.OrdinalIgnoreCase);

                // 2. Definir el nuevo estado numérico/bit para SQL (1 = Activo, 0 = Inactivo)
                int nuevoEstadoBD = estadoActual ? 0 : 1;

                // 3. Etiquetas dinámicas
                string accionTexto = estadoActual ? "desactivar" : "activar";
                string tituloConfirmacion = estadoActual ? "Confirmar Desactivación" : "Confirmar Activación";

                // Pedir confirmación
                DialogResult respuesta = MessageBox.Show(
                    $"¿Está seguro de que desea {accionTexto} al usuario '{usuarioNombre}'?",
                    tituloConfirmacion,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    CambiarEstadoUsuario(idUsuario, nuevoEstadoBD);
                    CargarUsuarios(); // Refresca la grilla y dispara automáticamente SelectionChanged
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método auxiliar para actualizar el estado en la base de datos
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

        // Evento que actualiza el texto del botón BEstado al cambiar la selección en el DataGridView
        private void DGVUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVUsuarios.SelectedRows.Count > 0 && DGVUsuarios.CurrentRow != null)
            {
                object valorEstado = DGVUsuarios.CurrentRow.Cells["Estado"].Value;

                if (valorEstado != null && valorEstado != DBNull.Value)
                {
                    string estadoTexto = valorEstado.ToString().Trim();

                    // Evaluamos si el usuario está activo (ya sea que la celda diga "Activo", "1" o "True")
                    bool estaActivo = estadoTexto.Equals("Activo", StringComparison.OrdinalIgnoreCase)
                                   || estadoTexto == "1"
                                   || estadoTexto.Equals("True", StringComparison.OrdinalIgnoreCase);

                    // Si está activo muestra "Desactivar", si está inactivo muestra "Activar"
                    BEstado.Text = estaActivo ? "Desactivar" : "Activar";
                }
            }
        }
    }
}