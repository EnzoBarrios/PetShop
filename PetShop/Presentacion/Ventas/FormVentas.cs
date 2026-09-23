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
        public FormVentas()
        {
            InitializeComponent();
        }

        private void DgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Verifica que se haya presionado la columna del botón eliminar
            if (dgvVenta.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                dgvVenta.Rows.RemoveAt(e.RowIndex);

                // Opcional: Llamar a tu método de recalcular total
                // CalcularTotal();
            }
        }

        private void DgvVenta_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // 1. Evitar pintar en la fila de encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // 2. Verificar que sea la columna de eliminación (usa el nombre que le diste a la columna)
            if (dgvVenta.Columns[e.ColumnIndex].Name == "btnQuitarProducto")
            {
                // Pinta las partes estándar de la celda (fondo, bordes de selección) excepto el contenido/texto
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Obtenemos la imagen desde Properties.Resources
                var icono = Properties.Resources.Eliminar; // Reemplaza con el nombre de tu recurso

                // Dimensiones deseadas para el icono
                int anchoIcono = 18;
                int altoIcono = 18;

                // Calculamos la posición centrada dentro de la celda
                int posicionX = e.CellBounds.Left + (e.CellBounds.Width - anchoIcono) / 2;
                int posicionY = e.CellBounds.Top + (e.CellBounds.Height - altoIcono) / 2;

                // Dibujamos la imagen centrada
                e.Graphics.DrawImage(icono, new Rectangle(posicionX, posicionY, anchoIcono, altoIcono));

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
