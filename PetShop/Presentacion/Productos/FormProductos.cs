using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.Entidades;
using PetShop.Negocio;
using PetShop.Presentacion.Productos;

namespace PetShop.Presentacion
{
    public partial class FormProductos : Form
    {
        private readonly CN_Producto _cnProducto;
        private bool _filtrarSoloStockMinimo = false; // Bandera para controlar el filtro de stock mínimo
        private readonly Timer _timerBusqueda; // Timer para aplicar Debounce en el buscador

        public FormProductos()
        {
            this.SuspendLayout();

            InitializeComponent();
            _cnProducto = new CN_Producto();
            btnStock.Text = "Stock Crítico";

            _timerBusqueda = new Timer { Interval = 300 };
            _timerBusqueda.Tick += TimerBusqueda_Tick;

            // Doble búfer en el DataGridView para eliminar el parpadeo al redimensionar
            typeof(DataGridView).GetProperty("DoubleBuffered", 
                System.Reflection.BindingFlags.Instance | 
                System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgvProductos, true, null);

            // Doble Búfer por reflexión en la Grilla de Productos
            typeof(DataGridView).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(dgvProductos, true, null);

            this.ResumeLayout(true);
        }

        private async void FormProductos_Shown(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            await CargarProductosAsync();
        }

        private void ConfigurarGrilla()
        {
            dgvProductos.AutoGenerateColumns = false;

            colId.DataPropertyName = nameof(Producto.IdProducto);
            colCodigo.DataPropertyName = nameof(Producto.Codigo);
            colNombre.DataPropertyName = nameof(Producto.Nombre);
            colDescripcion.DataPropertyName = nameof(Producto.Descripcion);
            colCategoria.DataPropertyName = nameof(Producto.Categoria.NombreCategoria);
            colStock.DataPropertyName = nameof(Producto.StockActual);
            colEstado.DataPropertyName = nameof(Producto.Estado);
        }

        public async Task CargarProductosAsync()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string filtro = txtBuscar.Text.Trim();

                List<Producto> listaProductos = await Task.Run(() => _cnProducto.ListarProductos(filtro));

                if (_filtrarSoloStockMinimo)
                {
                    listaProductos = listaProductos
                        .Where(p => p.StockActual <= p.StockMinimo)
                        .ToList();
                }

                dgvProductos.SuspendLayout();
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = listaProductos;

                ColorearFilasPorStock();
                ActualizarTextoBotonEstado();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[Error CargarProductos]: {ex}");
                MessageBox.Show(
                    "Ocurrió un inconveniente al cargar el listado de productos. Por favor, intente nuevamente.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            finally
            {
                dgvProductos.ResumeLayout(true);
                this.Cursor = Cursors.Default;
            }
        }

        // Método para pintar filas una sola vez al terminar la carga de datos
        private void ColorearFilasPorStock()
        {
            // -------------------------------------------------------------
            // 1. APLICAR COLORES PERSONALIZADOS SEGÚN EL STOCK
            // -------------------------------------------------------------
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.DataBoundItem is Producto producto)
                {
                    // Caso 1: Sin Stock
                    if (producto.StockActual <= 0)
                    {
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 100, 115);
                        fila.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 4, 45); // Cherry (Cereza intenso al seleccionar)
                        fila.DefaultCellStyle.SelectionForeColor = Color.White; // Texto blanco al seleccionar 
                    }
                    // Caso 2: Stock Mínimo alcanzado o superado 
                    else if (producto.StockActual <= producto.StockMinimo)
                    {
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 225, 75);
                        fila.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 216, 0); // Rubber Ducky (Amarillo patito al seleccionar)
                        fila.DefaultCellStyle.SelectionForeColor = Color.Black;
                    }
                    // Caso 3: Stock Normal
                    else
                    {
                        fila.DefaultCellStyle.BackColor = Color.White;
                        fila.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                        fila.DefaultCellStyle.SelectionForeColor = Color.White;
                    }
                }
            }
        }

        private Producto ObtenerProductoSeleccionado()
        {
            if (dgvProductos.Rows.Count == 0 ||
                dgvProductos.CurrentCell == null ||
                dgvProductos.SelectedRows.Count == 0)
            {
                return null;
            }

            return dgvProductos.CurrentRow.DataBoundItem as Producto;
        }

        private void ActualizarTextoBotonEstado()
        {
            Producto producto = ObtenerProductoSeleccionado();

            if (producto != null)
            {
                btnEstado.Text = producto.Estado ? "Desactivar" : "Activar";
                btnEstado.Enabled = true;
            }
            else
            {
                btnEstado.Text = "Cambiar Estado";
                btnEstado.Enabled = false;
            }
        }

        private void DgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarTextoBotonEstado();
        }

        private void DgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvProductos.Rows.Count) return;

            string columna = dgvProductos.Columns[e.ColumnIndex].Name;

            if (dgvProductos.Rows[e.RowIndex].DataBoundItem is Producto producto)
            {
                // -------------------------------------------------------------
                // 2. FORMATO DE TEXTO DE COLUMNAS
                // -------------------------------------------------------------
                if (columna == "colCategoria")
                {
                    e.Value = producto.Categoria?.NombreCategoria ?? "Sin Categoria";
                    e.FormattingApplied = true;
                }
                else if (columna == "colEstado")
                {
                    e.Value = producto.Estado ? "Activo" : "Inactivo";
                    e.FormattingApplied = true;
                }
                else if (columna == "colFecha")
                {
                    e.Value = producto.FechaCreacion.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }

        // Filtro en la caja de texto de Buscar
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            _timerBusqueda.Stop();
            _timerBusqueda.Start();
        }

        private async void TimerBusqueda_Tick(object sender, EventArgs e)
        {
            _timerBusqueda.Stop();
            await CargarProductosAsync();
        }

        // BOTÓN FILTRAR POR STOCK MÍNIMO / VER TODOS
        private async void BtnStock_Click(object sender, EventArgs e)
        {
            _filtrarSoloStockMinimo = !_filtrarSoloStockMinimo;

            if (_filtrarSoloStockMinimo)
            {
                btnStock.Text = "Ver Todos";
                btnStock.BackColor = Color.LightBlue; // Resalta el botón indicando que el filtro está activo
            }
            else
            {
                btnStock.Text = "Stock Crítico";
                btnStock.BackColor = SystemColors.Control; // Vuelve al color original
            }

            await CargarProductosAsync();
        }

        // BOTON AGREGAR PRODUCTO
        private async void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            using (FormCargaProducto formAlta = new FormCargaProducto())
            {
                if (formAlta.ShowDialog() == DialogResult.OK)
                {
                   await CargarProductosAsync();
                }
            }
        }

        // BOTON MODIFICAR PRODUCTO 
        private async void BtnModificarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = ObtenerProductoSeleccionado();

            if (producto == null)
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista para modificar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FormModificarProducto formModif = new FormModificarProducto(producto.IdProducto))
            {
                if (formModif.ShowDialog() == DialogResult.OK)
                {
                    await CargarProductosAsync();
                }
            }
        }

        // BOTON CAMBIAR ESTADO
        private async void BtnEstado_Click(object sender, EventArgs e)
        {
            Producto producto = ObtenerProductoSeleccionado();

            if (producto == null)
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool nuevoEstado = !producto.Estado;
            string accionTexto = producto.Estado ? "desactivar" : "activar";
            string tituloConfirmacion = producto.Estado ? "Confirmar Desactivación" : "Confirmar Activación";

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de que desea {accionTexto} al producto '{producto.Nombre}'?",
                tituloConfirmacion,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                // La capa de negocio valida el ID y actualiza en BD
                bool exito = _cnProducto.CambiarEstado(producto.IdProducto, nuevoEstado, out string mensaje);

                if (exito)
                {
                    MessageBox.Show(mensaje, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarProductosAsync();
                }
                else
                {
                    MessageBox.Show(mensaje, "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Botón Volver
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}