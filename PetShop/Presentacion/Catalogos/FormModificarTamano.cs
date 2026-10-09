using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.Negocio;
using PetShop.Entidades;

namespace PetShop.Presentacion.Catalogos
{
    public partial class FormModificarTamano : Form
    {
        private readonly int _idTamano;
        private readonly CN_Tamano _cnTamano = new CN_Tamano();
        private readonly ErrorProvider _ep = new ErrorProvider();

        public FormModificarTamano(int idTamano)
        {
            InitializeComponent();
            _idTamano = idTamano;
        }

        private void FormModificarTamano_Load(object sender, EventArgs e)
        {
            ActualizarNota();
            CargarEstados();
            CargarDatosTamano();
        }

        private void CbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarNota();
        }

        private void ActualizarNota()
        {
            if (cbxEstado.Text.Trim().Equals("Inactivo"))
            {
                lblNota.Text = $"Al desactivar la especie, no se podrán \n crear nuevas combinaciones con ella";
            }
            else
            {
                lblNota.Text = string.Empty;
            }
        }

        private void CargarEstados()
        {
            cbxEstado.Items.Clear();
            cbxEstado.Items.Add("Activo");
            cbxEstado.Items.Add("Inactivo");
        }

        private void CargarDatosTamano()
        {
            try
            {
                Tamano tamanoActual = _cnTamano.ObtenerTamanoPorId(_idTamano);

                if (tamanoActual != null)
                {
                    txtNombre.Text = tamanoActual.Nombre;
                    txtNombre.Focus();

                    cbxEstado.Text = tamanoActual.Estado ? "Activo" : "Inactivo";
                }
                else
                {
                    MessageBox.Show("No se encontró el tamaño especificado.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del tamaño: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea guardar los cambios del tamaño?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            Tamano tamano = new Tamano()
            {
                IdTamano = _idTamano,
                Nombre = txtNombre.Text.Trim(),
                Estado = cbxEstado.Text.Trim().Equals("Activo", StringComparison.OrdinalIgnoreCase),
            };

            bool exito = _cnTamano.ModificarTamano(tamano, out string mensaje);

            RespuestaModificacion(exito, mensaje);
        }

        private bool ValidarCampos()
        {
            _ep.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                _ep.SetError(txtNombre, "El nombre del tamaño es obligatorio.");
                txtNombre.Focus();
                esValido = false;
            }
            if (txtNombre.Text.Length < 3)
            {
                _ep.SetError(txtNombre, "El nombre del tamaño debe tener al menos 3 letras.");
                txtNombre.Focus();
                esValido = false;
            }
            // Validación de Selección de Estado
            if (cbxEstado.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                _ep.SetError(cbxEstado, "Debe seleccionar un estado.");
                esValido = false;
            }
            return esValido;
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
