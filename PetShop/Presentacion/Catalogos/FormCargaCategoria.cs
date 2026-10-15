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
    public partial class FormCargaCategoria : Form
    {
        private readonly ErrorProvider _ep = new ErrorProvider();
        private readonly CN_Categoria _cnCategoria = new CN_Categoria();

        public FormCargaCategoria()
        {
            InitializeComponent();
        }

        private void FormCargaCategoria_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
            ActualizarContadorCaracteres();
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

        // BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, verifique los campos marcados con advertencias.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria nuevaCategoria = new Categoria
            {
                NombreCategoria = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Estado = true
            };

            bool exito = _cnCategoria.RegistrarCategoria(nuevaCategoria, out string mensaje);

            RespuestaRegistro(exito, mensaje);
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

        private void RespuestaRegistro(bool exito, string mensaje)
        {
            if (exito)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (mensaje.IndexOf("nombre", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    mensaje.IndexOf("existe", StringComparison.OrdinalIgnoreCase) >= 0)
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
