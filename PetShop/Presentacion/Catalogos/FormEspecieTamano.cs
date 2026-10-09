using PetShop.Datos;
using PetShop.Entidades;
using PetShop.Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PetShop.Presentacion.Catalogos
{
    public partial class FormEspecieTamano : Form
    {
        private readonly CN_EspecieTamano _cnEspecieTamano;
        private List<EspecieTamano> _listaRelaciones;

        public FormEspecieTamano()
        {
            InitializeComponent();
            _cnEspecieTamano = new CN_EspecieTamano();
            _listaRelaciones = new List<EspecieTamano>();
        }

        private void FormEspecieTamano_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            CargarDatos();
        }

        private void ConfigurarGrilla()
        {
            dgvEspecieTamano.AutoGenerateColumns = false;

            // Mapeo seguro contra las propiedades públicas de la entidad
            colEspecie.DataPropertyName = nameof(EspecieTamano.NombreEspecie);
            colTamano.DataPropertyName = nameof(EspecieTamano.NombreTamano);
            colEstado.DataPropertyName = nameof(EspecieTamano.Estado);
        }

        public void CargarDatos()
        {
            try
            {
                string filtro = txtBuscar.Text.Trim();
                _listaRelaciones = _cnEspecieTamano.ListarRelaciones(filtro);
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el listado de combinaciones: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFiltros()
        {
            IEnumerable<EspecieTamano> consulta = _listaRelaciones;

            // Filtro por Estado
            if (rbActivos.Checked)
            {
                consulta = consulta.Where(r => r.Estado);
            }
            else if (rbInactivos.Checked)
            {
                consulta = consulta.Where(r => !r.Estado);
            }

            dgvEspecieTamano.DataSource = null;
            dgvEspecieTamano.DataSource = consulta.ToList();

            ActualizarBotonEstado();
        }

        private EspecieTamano ObtenerEspecieTamanoSeleccionado()
        {
            if (dgvEspecieTamano.Rows.Count == 0 ||
                dgvEspecieTamano.CurrentRow == null ||
                dgvEspecieTamano.SelectedRows.Count == 0)
            {
                return null;
            }

            return dgvEspecieTamano.CurrentRow.DataBoundItem as EspecieTamano;
        }

        private void ActualizarBotonEstado()
        {
            EspecieTamano sel = ObtenerEspecieTamanoSeleccionado();

            if (sel != null)
            {
                btnCambiarEstado.Text = sel.Estado ? "Desactivar" : "Activar";
                btnCambiarEstado.Enabled = true;
            }
            else
            {
                btnCambiarEstado.Text = "Cambiar Estado";
                btnCambiarEstado.Enabled = false;
            }
        }

        private void DgvMascotas_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarBotonEstado();
        }

        private void DgvMascotas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvEspecieTamano.Rows.Count) return;

            string columna = dgvEspecieTamano.Columns[e.ColumnIndex].DataPropertyName;

            if (columna == nameof(EspecieTamano.Estado) && e.Value is bool estado)
            {
                e.Value = estado ? "Activo" : "Inactivo";
                e.FormattingApplied = true;
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void RbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                AplicarFiltros();
            }
        }

        // BOTÓN: AGREGAR ESPECIE (Abre formulario modal para dar de alta una especie en su tabla maestra)
        private void BtnAgregarEspecie_Click(object sender, EventArgs e)
        {
            using (FormCargaEspecie formAlta = new FormCargaEspecie())
            {
                if (formAlta.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
        }

        private void BtnAgregarTamano_Click(object sender, EventArgs e)
        {
            using (FormCargaTamano formAlta = new FormCargaTamano())
            {
                if (formAlta.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
        }

        private void BtnModificarEspecie_Click(object sender, EventArgs e)
        {
            EspecieTamano especieTamano = ObtenerEspecieTamanoSeleccionado();

            if (especieTamano == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría de la lista para modificar.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormModificarEspecie formModificacion = new FormModificarEspecie(especieTamano.IdEspecie))
            {
                if (formModificacion.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
        }

        private void BtnModificarTamano_Click(object sender, EventArgs e)
        {
            EspecieTamano especieTamano = ObtenerEspecieTamanoSeleccionado();

            if (especieTamano == null)
            {
                MessageBox.Show("Por favor, seleccione una categoría de la lista para modificar.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormModificarTamano formModificacion = new FormModificarTamano(especieTamano.IdTamano))
            {
                if (formModificacion.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
        }

        // BOTÓN: ASIGNAR NUEVA COMBINACIÓN (Abre modal con dos ComboBoxes: Especie y Tamaño)
        private void BtnAsignarCombinacion_Click(object sender, EventArgs e)
        {
            using (FormAsignarEspecieTamano formAsignar = new FormAsignarEspecieTamano())
            {
                if (formAsignar.ShowDialog() == DialogResult.OK)
                {
                    CargarDatos();
                }
            }
        }

        // BOTÓN: CAMBIAR ESTADO (Baja lógica sobre la tupla Especie_Tamano)
        private void BtnCambiarEstado_Click(object sender, EventArgs e)
        {
            EspecieTamano seleccionado = ObtenerEspecieTamanoSeleccionado();

            if (seleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione una combinación de la lista.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool nuevoEstado = !seleccionado.Estado;
            string accion = seleccionado.Estado ? "desactivar" : "activar";

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea {accion} la combinación '{seleccionado.NombreEspecie} - {seleccionado.NombreTamano}'?",
                "Confirmación de Estado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                bool exito = _cnEspecieTamano.CambiarEstado(
                    seleccionado.IdEspecie,
                    seleccionado.IdTamano,
                    nuevoEstado,
                    out string mensaje
                );

                if (exito)
                {
                    MessageBox.Show(mensaje, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Acción Denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}