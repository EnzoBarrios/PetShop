using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PetShop.Entidades;
using PetShop.Negocio;

namespace PetShop.Presentacion.Catalogos
{
    public partial class FormCargaEspecie : Form
    {
        private readonly ErrorProvider _ep = new ErrorProvider();
        private readonly CN_Especie _cnEspecie = new CN_Especie();

        public FormCargaEspecie()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            Especie nuevaEspecie = new Especie
            {
                Nombre = txtNombre.Text.Trim(),
                Estado = true
            };

            bool exito = _cnEspecie.RegistrarEspecie(nuevaEspecie, out string mensaje);

            RespuestaRegistro(exito, mensaje);
        }

        private bool ValidarCampos()
        {
            _ep.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                _ep.SetError(txtNombre, "El nombre de la especie es obligatorio.");
                txtNombre.Focus();
                return false;
            }
            if (txtNombre.Text.Length < 3)
            {
                _ep.SetError(txtNombre, "El nombre tiene que tener al menos 3 letras.");
                txtNombre.Focus();
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
