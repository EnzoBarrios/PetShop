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

        // Guardamos la tabla a nivel de clase para que los filtros funcionen
        private DataTable tablaProductos;
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // Cargar los datos de prueba en el DataGridView al cargar el formulario
            CargarGrillaProductos();
        }

        public void CargarGrillaProductos()
        {
            tablaProductos = new DataTable();

            // Definir las columnas
            tablaProductos.Columns.Add("ID", typeof(int));
            tablaProductos.Columns.Add("Código barra", typeof(string));
            tablaProductos.Columns.Add("Nombre", typeof(string));
            tablaProductos.Columns.Add("Descripción", typeof(string));
            tablaProductos.Columns.Add("Especie", typeof(string));
            tablaProductos.Columns.Add("Categoría", typeof(string));
            tablaProductos.Columns.Add("Proveedor", typeof(string));
            tablaProductos.Columns.Add("Precio compra", typeof(decimal));
            tablaProductos.Columns.Add("Precio venta", typeof(decimal));
            tablaProductos.Columns.Add("Cantidad", typeof(int));

            // Cargar filas de prueba
            tablaProductos.Rows.Add(
                1,
                "77912345",
                "Sieger Adulto 20kg",
                "Alimento balanceado perros raza grande",
                "Perro",
                "Alimentos",
                "Distribuidora Pet",
                32000.00m,
                45000.00m,
                10
            );

            tablaProductos.Rows.Add(
                2,
                "77956789",
                "Cat Chow Pescado 3kg",
                "Alimento seco para gatos adultos",
                "Gato",
                "Alimentos",
                "Purina Oficial",
                8500.00m,
                12000.00m,
                5
            );

            // Asignar la tabla como origen de datos del DataGridView
            DGVProductos.DataSource = tablaProductos;

            // Oculta la columna ID
            if (DGVProductos.Columns["ID"] != null)
            {
                DGVProductos.Columns["ID"].Visible = false;
            }
        }

        //Botón Nuevo Producto
        private void BNuevoProducto_Click(object sender, EventArgs e)
        {
            FormCargaProducto formCargarProducto = new FormCargaProducto();

            //bloquea la interacción con las demás ventanas hasta que el usuario la cierre
            if (formCargarProducto.ShowDialog() == DialogResult.OK)
            {
                CargarGrillaProductos(); //Actualiza la grilla de productos después de cerrar el formulario de carga
            }
        }

        //Botón Modificar 
        private void BModificarProducto_Click(object sender, EventArgs e)
        {
            if (DGVProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Obtener el ID del producto seleccionado
            int IDProductoSeleccionado = Convert.ToInt32(DGVProductos.SelectedRows[0].Cells["ID"].Value);

            // Abrir formulario de modificación de producto a traves del ID 
            /*
            FormModificarProducto formModificar = new FormModificarProducto(IDProductoSeleccionado);
            if (formModificar.ShowDialog() == DialogResult.OK)
            {
                CargarGrillaProductos(); //Actualiza la grilla de productos después de cerrar el formulario de modificación
            }
            */
        }

        //Filtro en la caja de texto de Buscar
        private void TBuscar_TextChanged(object sender, EventArgs e)
        {
            if(tablaProductos != null && tablaProductos.DefaultView != null)
            {
                string filtro = TBuscar.Text.Trim().Replace("'", "''");
                // Filtra tanto por columna Nombre como por Código
                tablaProductos.DefaultView.RowFilter = string.Format("Nombre LIKE '%{0}%' OR [Código barra] LIKE '%{0}%'", filtro);
            }
        }

        //Botón Eliminar 
        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            // 1. Validar que el usuario haya seleccionado una fila en la grilla
            if (DGVProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtener el ID y el Nombre del producto seleccionado para mostrar en el mensaje
            int idSeleccionado = Convert.ToInt32(DGVProductos.SelectedRows[0].Cells["ID"].Value);
            string nombreProducto = DGVProductos.SelectedRows[0].Cells["Nombre"].Value.ToString();

            // 3. Pedir confirmación al usuario antes de borrar
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar el producto '" + nombreProducto + "'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2 // Deja seleccionado "No" por seguridad
            );

            if (resultado == DialogResult.Yes)
            {
                // 4. eliminar la fila de la DataTable en memoria
                DataRow[] filas = tablaProductos.Select("ID = " + idSeleccionado);
                foreach (DataRow fila in filas)
                {
                    tablaProductos.Rows.Remove(fila);
                }

                MessageBox.Show("El producto se ha eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Botón Volver
        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
