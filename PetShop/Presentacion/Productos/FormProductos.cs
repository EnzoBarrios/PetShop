using PetShop.Datos;
using PetShop.Entidades;
using PetShop.Negocio;
using PetShop.Presentacion.Usuarios;
using PetShop.Presentacion.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PetShop.Presentacion
{
    public partial class FormProductos : Form
    {
        private readonly CN_Producto _cnProducto;

        public FormProductos()
        {
            InitializeComponent();
            _cnProducto = new CN_Producto();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            CargarProductos();
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

        public void CargarProductos()
        {
            try
            {
                string filtro = txtBuscar.Text.Trim();

                // Lista tipada desde la capa de negocio
                List<Producto> listaProductos = _cnProducto.ListarProductos(filtro);

                dgvProductos.DataSource = null;
                dgvProductos.DataSource = listaProductos;

                ActualizarTextoBotonEstado();
            }
            catch (Exception ex)
            {
                // Registro del error en log de servidor/consola (Seguridad por diseño)
                System.Diagnostics.Debug.WriteLine($"[Error CargarProductos]: {ex}");

                // Mensaje claro y seguro para el usuario
                MessageBox.Show(
                    "Ocurrió un inconveniente al cargar el listado de productos. Por favor, intente nuevamente.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
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
                // 1. APLICAR COLOR A LA FILA SEGÚN EL STOCK
                // -------------------------------------------------------------
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                // Caso 1: Sin Stock (Rojo claro)
                if (producto.StockActual <= 0)
                {
                    fila.DefaultCellStyle.BackColor = Color.MistyRose;
                    fila.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
                    fila.DefaultCellStyle.SelectionForeColor = Color.White;
                }
                // Caso 2: Stock Mínimo alcanzado o superado (Amarillo claro)
                else if (producto.StockActual <= producto.StockMinimo)
                {
                    fila.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    fila.DefaultCellStyle.SelectionBackColor = Color.DarkKhaki;
                    fila.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
                // Caso 3: Stock Normal (Color de fondo por defecto)
                else
                {
                    fila.DefaultCellStyle.BackColor = Color.White;
                    fila.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                    fila.DefaultCellStyle.SelectionForeColor = Color.White;
                }

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
                    // Formato de texto para el booleano Estado
                    e.Value = producto.Estado ? "Activo" : "Inactivo";
                    e.FormattingApplied = true;
                }
                // Formato de fecha uniforme
                else if (columna == "colFecha")
                {
                    e.Value = producto.FechaCreacion.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }

        //Filtro en la caja de texto de Buscar
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        // BOTON AGREGAR PRODUCTO
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            using (FormCargaProducto formAlta = new FormCargaProducto())
            {
                if (formAlta.ShowDialog() == DialogResult.OK)
                {
                    CargarProductos();
                }
            }
        }

        // BOTON MODIFICAR PRODUCTO 
        private void BtnModificarProducto_Click(object sender, EventArgs e)
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
                    CargarProductos();
                }
            }
        }

        // BOTON CAMBIAR ESTADO
        private void BtnEstado_Click(object sender, EventArgs e)
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
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Acción denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Botón Volver
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
