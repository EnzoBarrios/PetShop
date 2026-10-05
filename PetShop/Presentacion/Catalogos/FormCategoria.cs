using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.Negocio;
using PetShop.Entidades;

namespace PetShop.Presentacion.Catalogos
{
    public partial class FormCategoria : Form
    {
        private readonly CN_Categoria _cnCategoria;
        private List<Categoria> _listaCategoria;

        public FormCategoria()
        {
            InitializeComponent();
            _cnCategoria = new CN_Categoria();
            _listaCategoria = new List<Categoria>();
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarCategorias();
        }

        private void CargarGrilla()
        {
            dgvCategorias.AutoGenerateColumns = false;

            // Asegurar que las columnas del diseñador apunten a las propiedades de la entidad
            colId.DataPropertyName = nameof(Categoria.IdCategoria);
            colCategoria.DataPropertyName = nameof(Categoria.NombreCategoria);
            colDescripcion.DataPropertyName = nameof(Categoria.Descripcion);
            colEstado.DataPropertyName = nameof(Categoria.Estado);
        }

        private void CargarCategorias()
        {
            try
            {
                string filtro = txtBuscar.Text.Trim();
                _listaCategoria = _cnCategoria.ListarCategorias(filtro);
                AplicarFiltroEstado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el listado de categorías: {ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFiltroEstado()
        {
            List<Categoria> listaFiltrada = _listaCategoria;

            // Filtro según el RadioButton seleccionado
            if (rbActivos.Checked)
            {
                listaFiltrada = _listaCategoria.Where(c => c.Estado).ToList();
            }
            else if (rbInactivos.Checked)
            {
                listaFiltrada = _listaCategoria.Where(c => !c.Estado).ToList();
            }

            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = listaFiltrada;

            ActualizarTextoBotonEstado();
        }

        private Categoria ObtenerCategoriaSeleccionada()
        {
            if (dgvCategorias.CurrentRow == null || dgvCategorias.SelectedRows.Count == 0)
            {
                return null;
            }

            return dgvCategorias.CurrentRow.DataBoundItem as Categoria;
        }

        // Método que evalúa la fila seleccionada y ajusta texto, ícono y estado del botón
        private void ActualizarTextoBotonEstado()
        {
            Categoria categoria = ObtenerCategoriaSeleccionada();

            if (categoria != null)
            {
                btnEstado.Text = categoria.Estado ? "Desactivar" : "Activar";
                btnEstado.ImageIndex = categoria.Estado ? 2 : 1;
                btnEstado.Enabled = true;
            }
            else
            {
                btnEstado.Text = "Cambiar Estado";
                btnEstado.ImageIndex = 0;
                btnEstado.Enabled = false;
            }
        }

        // Evento que se dispara cuando cambia la selección en el DataGridView
        private void DgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarTextoBotonEstado();
        }

        // Evento que se dispara para formatear la celda del DataGridView
        private void DgvCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCategorias.Columns[e.ColumnIndex].DataPropertyName == nameof(Categoria.Estado) && e.Value is bool estado)
            {
                e.Value = estado ? "Activo" : "Inactivo";
                e.FormattingApplied = true;
            }
        }

        // Evento que se dispara cuando cambia el texto en el TextBox de búsqueda
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        // Evento que se dispara cuando cambia el estado de los RadioButtons
        private void RbEstado_CheckedChange(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                AplicarFiltroEstado();
            }
        }

        // BOTON AGREGAR 
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (FormCargaCategoria formAlta = new FormCargaCategoria())
            {
                if(formAlta.ShowDialog() == DialogResult.OK)
                {
                    CargarCategorias();
                }
            }
        }

        // BOTON MODIFICAR
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Categoria categoria = ObtenerCategoriaSeleccionada();

            if (categoria == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría de la lista para modificar.", 
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormModificarCategoria formModificacion = new FormModificarCategoria(categoria.IdCategoria))
            {
                if (formModificacion.ShowDialog() == DialogResult.OK)
                {
                    CargarCategorias();
                }
            }
        }

        // BOTON CAMBIAR ESTADO
        private void BtnEstado_Click(object sender, EventArgs e)
        {
            Categoria categoria = ObtenerCategoriaSeleccionada();

            if (categoria == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría de la lista.", 
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreCategoria = categoria.NombreCategoria;
            bool nuevoEstado = !categoria.Estado;
            string accionTexto = categoria.Estado ? "desactivar" : "activar";
            string tituloConfirmacion = categoria.Estado ? "Confirmar Desactivación" : "Confirmar Activación";

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de que desea {accionTexto} la categoría '{nombreCategoria}'?",
                tituloConfirmacion,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                bool exito = _cnCategoria.CambiarEstadoCategoria(categoria.IdCategoria, nuevoEstado, out string mensaje);

                if (exito)
                {
                    MessageBox.Show(mensaje, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCategorias(); 
                }
                else
                {
                    MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // BOTON VOLVER
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
