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
    public partial class FormModificarEspecie : Form
    {
        private readonly int _idEspecie;
        private readonly CN_Especie _cnEspecie = new CN_Especie();
        private readonly ErrorProvider _ep = new ErrorProvider();

        public FormModificarEspecie(int idEspecie)
        {
            InitializeComponent();
            _idEspecie = idEspecie;
        }

        private void FormModificarEspecie_Load(object sender, EventArgs e)
        {
            ActualizarNota();
            CargarEstados();
            CargarDatosEspecie();
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

        private void CargarDatosEspecie()
        {
            try
            {
                Especie especie = _cnEspecie.ObtenerEspeciePorId(_idEspecie);

                if (especie != null)
                {
                    txtNombre.Text = especie.Nombre;
                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show("No se encontró la especie especificada.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la especie: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                "¿Está seguro de que desea guardar los cambios de la especie?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            Especie especie = new Especie()
            {
                IdEspecie = _idEspecie,
                Nombre = txtNombre.Text.Trim(),
                Estado = cbxEstado.Text.Trim().Equals("Activo", StringComparison.OrdinalIgnoreCase),
            };

            bool exito = _cnEspecie.ModificarEspecie(especie, out string mensaje);

            RespuestaModificacion(exito, mensaje);
        }

        private bool ValidarCampos()
        {
            _ep.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                _ep.SetError(txtNombre, "El nombre de la especie es obligatorio.");
                txtNombre.Focus();
                esValido = false;
            }
            if (txtNombre.Text.Length < 3)
            {
                _ep.SetError(txtNombre, "El nombre de la especie debe tener almenos 3 letras.");
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
