using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PetShop.Entidades;
using PetShop.Negocio;

namespace PetShop.Presentacion.Usuarios
{
    public partial class FormUsuarios : Form
    {
        // Variables para almacenar el ID y el Rol del usuario logueado
        private readonly int _idUsuarioLogueado;
        private readonly string _rolUsuarioLogueado;
        private readonly CN_Usuario _cnUsuario; // Instancia de la capa de negocio para interactuar con la lógica de usuarios

        // Constructor principal que recibe el ID y el Rol del usuario logueado
        public FormUsuarios(int idUsuarioLogueado, string rolUsuarioLogueado)
        {
            InitializeComponent();
            _idUsuarioLogueado = idUsuarioLogueado;
            _rolUsuarioLogueado = rolUsuarioLogueado ?? string.Empty;
            _cnUsuario = new CN_Usuario(); 
        }

        // Evento que se dispara al cargar el formulario, invoca la carga inicial de usuarios
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            ConfigurarDatosGrilla();
            CargarUsuarios();
        }

        private void ConfigurarDatosGrilla()
        {
            dgvUsuarios.AutoGenerateColumns = false;

            // Mapeo seguro contra las propiedades públicas de la Entidad Usuario
            colId.DataPropertyName = nameof(Usuario.IdUsuario);
            colNombre.DataPropertyName = nameof(Usuario.Nombre);
            colApellido.DataPropertyName = nameof(Usuario.Apellido);
            colUsuario.DataPropertyName = nameof(Usuario.NombreUsuario);
            colEstado.DataPropertyName = nameof(Usuario.Estado);
            colFecha.DataPropertyName = nameof(Usuario.FechaCreacion);
        }

        // Método para cargar los usuarios en el DataGridView, con un filtro opcional
        private void CargarUsuarios()
        {
            try
            {
                string filtro = txtBuscar.Text.Trim();

                // Lista tipada desde la capa de negocio
                List<Usuario> listaUsuarios = _cnUsuario.CargarUsuariosParaGrilla(_rolUsuarioLogueado, filtro);

                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = listaUsuarios;

                ActualizarTextoBotonEstado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de usuarios: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Usuario ObtenerUsuarioSeleccionado()
        {
            if (dgvUsuarios.Rows.Count == 0 ||
                dgvUsuarios.CurrentCell == null || 
                dgvUsuarios.SelectedRows.Count == 0)
            {
                return null;
            }

            return dgvUsuarios.CurrentRow.DataBoundItem as Usuario;
        }

        private void ActualizarTextoBotonEstado()
        {
            Usuario usuario = ObtenerUsuarioSeleccionado();

            if (usuario != null)
            {
                btnEstado.Text = usuario.Estado ? "Desactivar" : "Activar";
                btnEstado.Enabled = true;                    
            }
            else
            {
                btnEstado.Text = "Cambiar Estado";
                btnEstado.Enabled = false; 
            }
        }

        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarTextoBotonEstado();
        }

        private void DgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvUsuarios.Rows.Count) return;

            string columna = dgvUsuarios.Columns[e.ColumnIndex].Name;
            
            if (dgvUsuarios.Rows[e.RowIndex].DataBoundItem is Usuario usuario)
            {
                if (columna == "colRol")
                {
                    // Formato para columna Rol (Navegación u.Rol.NombreRol)
                    e.Value = usuario.Rol?.NombreRol ?? "Sin Rol";
                    e.FormattingApplied = true;
            
                }
                else if (columna == "colEstado")
                {
                    // Formato de texto para el booleano Estado
                    e.Value = usuario.Estado ? "Activo" : "Inactivo";
                    e.FormattingApplied = true;
                }
                // Formato de fecha uniforme
                else if (columna == "colFecha")
                {
                    e.Value = usuario.FechaCreacion.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        // BOTÓN NUEVO USUARIO
        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            using (FormCargaUsuario formAlta = new FormCargaUsuario(_rolUsuarioLogueado))
            {
                if(formAlta.ShowDialog() == DialogResult.OK)
                {
                    CargarUsuarios();
                }
            }
        }

        // BOTÓN MODIFICAR
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Usuario usuario = ObtenerUsuarioSeleccionado();

            if (usuario == null)
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista para modificar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación: Evita modificar la propia cuenta en sesión
            if (usuario.IdUsuario == _idUsuarioLogueado)
            {
                MessageBox.Show("No puede modificar los datos de su propia cuenta activa desde este panel.", "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormModificarUsuario formModif = new FormModificarUsuario(usuario.IdUsuario, _rolUsuarioLogueado))
            {
                if(formModif.ShowDialog() == DialogResult.OK)
                {
                    CargarUsuarios();
                }
            }
        }

        // BOTÓN CAMBIAR ESTADO (ACTIVAR / DESACTIVAR)
        private void BtnEstado_Click(object sender, EventArgs e)
        {
            Usuario usuario = ObtenerUsuarioSeleccionado();

            if (usuario == null)
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool nuevoEstado = !usuario.Estado;
            string accionTexto = usuario.Estado ? "desactivar" : "activar";
            string tituloConfirmacion = usuario.Estado ? "Confirmar Desactivación" : "Confirmar Activación";


            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de que desea {accionTexto} al usuario '{usuario.NombreUsuario}'?",
                tituloConfirmacion,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                // La capa de negocio valida el ID y actualiza en BD
                bool exito = _cnUsuario.CambiarEstadoUsuario(usuario.IdUsuario, _idUsuarioLogueado, nuevoEstado, out string mensaje);

                if (exito)
                {
                    MessageBox.Show(mensaje, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsuarios();
                }
                else
                {
                    MessageBox.Show(mensaje, "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // BOTÓN VOLVER
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}