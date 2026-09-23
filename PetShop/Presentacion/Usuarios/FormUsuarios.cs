using PetShop.Entidades;
using PetShop.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PetShop.Presentacion.Usuarios
{
    public partial class FormUsuarios : Form
    {
        // Variables para almacenar el ID y el Rol del usuario logueado
        private readonly int _idUsuarioLogueado;
        private readonly string _rolUsuarioLogueado;
        private readonly CN_Usuario _cnUsuario = new CN_Usuario(); // Instancia de la capa de negocio para interactuar con la lógica de usuarios

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

        // Evento que se dispara al cargar el formulario, invoca la carga inicial de usuarios
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        // Método para cargar los usuarios en el DataGridView, con un filtro opcional
        private void CargarUsuarios(string filtro = "")
        {
            try
            {
                // Lista tipada desde la capa de negocio
                List<Usuario> listaUsuarios = _cnUsuario.CargarUsuariosParaGrilla(_rolUsuarioLogueado, filtro);


                // Lista anónima formateada para que coincida exactamente con las columnas del DataGridView
                var datosGrilla = listaUsuarios.Select(u => new
                {
                    Id = u.IdUsuario,
                    Nom = u.Nombre,
                    Ape = u.Apellido,
                    Usuario = u.NombreUsuario,
                    Rol = u.Rol?.NombreRol ?? "Sin Rol",
                    Estado = u.Estado ? "Activo" : "Inactivo",
                    FechaCreacion = u.FechaCreacion.ToString("dd/MM/yyyy")
                }).ToList();

                DGVUsuarios.DataSource = datosGrilla;

                // Si existen columnas generadas automáticamente con encabezado largo, ajustamos el texto visual
                if (DGVUsuarios.Columns.Contains("FechaCreacion"))
                {
                    DGVUsuarios.Columns["FechaCreacion"].HeaderText = "Fecha Creación";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTÓN NUEVO USUARIO
        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            using (FormCargaUsuario formAlta = new FormCargaUsuario())
            {
                formAlta.ShowDialog();
            }

            CargarUsuarios(TBuscar.Text.Trim());
        }

        // BOTÓN MODIFICAR
        private void BtnModificar_Click(object sender, EventArgs e)
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

                using (FormModificarUsuario formModif = new FormModificarUsuario(idUsuarioSeleccionado))
                {
                    formModif.ShowDialog();
                }

                CargarUsuarios(TBuscar.Text.Trim());
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // BOTÓN CAMBIAR ESTADO (ACTIVAR / DESACTIVAR)
        private void BtnEstado_Click(object sender, EventArgs e)
        {
            if (DGVUsuarios.SelectedRows.Count > 0 && DGVUsuarios.CurrentRow != null)
            {
                int idUsuarioSeleccionado = Convert.ToInt32(DGVUsuarios.CurrentRow.Cells["ID"].Value);
                string usuarioNombre = DGVUsuarios.CurrentRow.Cells["Usuario"].Value?.ToString() ?? "";
                string estadoTexto = DGVUsuarios.CurrentRow.Cells["Estado"].Value?.ToString().Trim() ?? "";

                bool estaActivo = estadoTexto.Equals("Activo", StringComparison.OrdinalIgnoreCase);
                bool nuevoEstado = !estaActivo;

                string accionTexto = estaActivo ? "desactivar" : "activar";
                string tituloConfirmacion = estaActivo ? "Confirmar Desactivación" : "Confirmar Activación";

                DialogResult respuesta = MessageBox.Show(
                    $"¿Está seguro de que desea {accionTexto} al usuario '{usuarioNombre}'?",
                    tituloConfirmacion,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    // La capa de negocio valida el ID y actualiza en BD
                    bool exito = _cnUsuario.CambiarEstadoUsuario(idUsuarioSeleccionado, _idUsuarioLogueado, nuevoEstado, out string mensaje);

                    if (exito)
                    {
                        MessageBox.Show(mensaje, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarUsuarios(TBuscar.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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

                    btnEstado.Text = estaActivo ? "Desactivar" : "Activar";
                }
            }
        }
    }
}