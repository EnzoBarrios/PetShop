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
    public partial class FormVentas : Form
    {
        // Definicion de la imagen del icono de eliminación como un recurso estático
        private static readonly Image _iconoEliminar = Properties.Resources.Eliminar;

        public FormVentas()
        {
            InitializeComponent();

            // Habilitar DoubleBuffered para evitar parpadeos y acelerar CellPainting
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, dgvVenta, new object[] { true });
        }

        /*
        private void DgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Verifica que se haya presionado la columna del botón quitar producto
            if (dgvVenta.Columns[e.ColumnIndex].Name == "btnQuitarProducto")
            {
                dgvVenta.Rows.RemoveAt(e.RowIndex);

                // Opcional: Llamar a tu método de recalcular total
                // CalcularTotal();
            }
        }
        */

        private void DgvVenta_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Evitar pintar en la fila de encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Verificar que sea la columna de eliminación
            if (dgvVenta.Columns[e.ColumnIndex].Name == "btnQuitarProducto")
            {
                // Pinta las partes estándar de la celda (fondo, bordes de selección) excepto el contenido/texto
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Dimensiones deseadas para el icono
                int anchoIcono = 18;
                int altoIcono = 18;

                // Calculamos la posición centrada dentro de la celda
                int posicionX = e.CellBounds.Left + (e.CellBounds.Width - anchoIcono) / 2;
                int posicionY = e.CellBounds.Top + (e.CellBounds.Height - altoIcono) / 2;

                // Dibujamos la imagen centrada
                e.Graphics.DrawImage(_iconoEliminar, new Rectangle(posicionX, posicionY, anchoIcono, altoIcono));

                // Marcamos el evento como manejado para evitar que el DataGridView dibuje encima
                e.Handled = true;
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
