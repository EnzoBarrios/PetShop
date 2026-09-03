using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto2
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void LPrecioUnit_Click(object sender, EventArgs e)
        {

        }

        private void TDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void LEspecie_Click(object sender, EventArgs e)
        {

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // Crear una tabla temporal en memoria
            DataTable tabla = new DataTable();

            // Definir las columnas
            tabla.Columns.Add("ID", typeof(int));
            tabla.Columns.Add("Código", typeof(string));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Precio Venta", typeof(decimal));
            tabla.Columns.Add("Stock", typeof(int));

            // Cargar un par de filas de prueba
            tabla.Rows.Add(1, "779123", "Sieger Adulto 20kg", 45000.00, 10);
            tabla.Rows.Add(2, "779456", "Dog Chow 3kg", 12000.00, 5);

            // Asignar la tabla como origen de datos del DataGridView
            DGVProductos.DataSource = tabla;
        }
    }
}
