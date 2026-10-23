using PetShop.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PetShop.Presentacion.Ventas
{
    public partial class FormBuscarProducto : Form
    {
        private readonly List<Producto> _listaProductos;
        public Producto ProductoSeleccionado { get; private set; }

        public FormBuscarProducto(List<Producto> listaProductos)
        {
            InitializeComponent();
            _listaProductos = listaProductos;
        }

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        private void CargarLista()
        {
            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.DataSource = null;

            // Proyecta las propiedades 'Codigo' y 'Nombre' para tus 2 columnas del diseñador
            dgvResultados.DataSource = _listaProductos.Select(p => new
            {
                ObjetoOriginal = p,
                Codigo = p.Codigo,
                Nombre = p.Nombre
            }).ToList();

            // Pone foco en la grilla para navegar inmediatamente con las flechas
            if (dgvResultados.Rows.Count > 0)
            {
                dgvResultados.Rows[0].Selected = true;
            }
            dgvResultados.Focus();
        }

        // CAPTURA DE LA TECLA ENTER (Evita que solo baje de fila en la grilla)
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && dgvResultados.Focused)
            {
                ConfirmarSeleccion();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // SELECCIÓN POR DOBLE CLIC
        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ConfirmarSeleccion();
            }
        }

        private void ConfirmarSeleccion()
        {
            if (dgvResultados.CurrentRow != null)
            {
                dynamic filaSeleccionada = dgvResultados.CurrentRow.DataBoundItem;
                if (filaSeleccionada != null)
                {
                    ProductoSeleccionado = (Producto)filaSeleccionada.ObjetoOriginal;
                    this.DialogResult = DialogResult.OK; // Devuelve OK a FormRegistrarVenta
                    this.Close();
                }
            }
        }
    }
}