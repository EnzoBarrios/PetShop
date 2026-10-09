using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.Entidades;
using PetShop.Negocio;

namespace PetShop.Presentacion.Catalogos
{
    public partial class FormModificarCategoria : Form
    {
        private readonly int _idCategoria;
        private readonly ErrorProvider _ep = new ErrorProvider();
        private readonly CN_Categoria _cnCategoria = new CN_Categoria();

        public FormModificarCategoria(int idCategoria)
        {
            InitializeComponent();
            _idCategoria = idCategoria;
        }

        private void FormModificarCategoria_Load(object sender, EventArgs e)
        {
            ActualizarContadorCaracteres();
            CargarDatosCategoria();
        }

        private void TxtDescripCategoria_TextChanged(object sender, EventArgs e)
        {
            ActualizarContadorCaracteres();
        }

        private void ActualizarContadorCaracteres()
        {
            lblContador.Text = $"{txtDescripcion.Text.Length} / 255";
            lblContador.ForeColor = txtDescripcion.Text.Length > 250 ? Color.Red : Color.DimGray;
        }

        private void CargarDatosCategoria()
        {
            try
            {
                Categoria categoriaActual = _cnCategoria.ObtenerCategoriaPorId(_idCategoria);

                if (categoriaActual != null)
                {
                    txtNombre.Text = categoriaActual.NombreCategoria;
                    txtDescripcion.Text = categoriaActual.Descripcion ?? string.Empty;
                    ActualizarContadorCaracteres();
                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show("No se encontró la categoría especificada.", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            Categoria categoriaActual = new Categoria
            {
                IdCategoria = _idCategoria,
                NombreCategoria = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
            };

            bool exito = _cnCategoria.ModificarCategoria(categoriaActual, out string mensaje);

            RespuestaModificacion(exito, mensaje);
        }

        private bool ValidarCampos()
        {
            _ep.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                _ep.SetError(txtNombre, "El nombre de la categoría es obligatorio.");
                txtNombre.Focus();
                return false;
            }
            if (txtDescripcion.Text.Length > 255)
            {
                _ep.SetError(txtDescripcion, "La descripción no puede exceder los 255 caracteres.");
                txtDescripcion.Focus();
                return false;
            }
            return true;
        }

        private void RespuestaModificacion(bool exito, string mensaje)
        {
            if (exito)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (mensaje.ToLower().Contains("nombre") || mensaje.ToLower().Contains("existe") || mensaje.ToLower().Contains("uso"))
                {
                    _ep.SetError(txtNombre, mensaje);
                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // BOTON CANCELAR
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
