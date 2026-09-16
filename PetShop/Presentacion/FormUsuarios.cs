using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetShop.Presentacion
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

        /// <summary>
        /// Trae la lista de usuarios desde SQL Server y la asigna al DataGridView.
        /// </summary>
        private void CargarUsuarios(string filtro = "")
        {
            // Consulta con INNER JOIN para mostrar el nombre del rol en lugar del ID
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

                        // Asignamos la tabla de resultados al DataGridView
                        // (Verificá si el name de tu grilla en el Diseñador es dgvUsuarios)
                        DGVUsuarios.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la lista de usuarios: " + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Evento TextChanged del campo de texto de búsqueda
        // (Asegurate de asociar este evento a tu TextBox desde la ventana de propiedades)
        private void TBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarUsuarios(TBuscar.Text.Trim());
        }

        // Evento del botón Volver
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}