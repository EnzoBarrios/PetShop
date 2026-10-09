using PetShop.Datos;
using PetShop.Entidades;
using PetShop.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Presentacion.Catalogos
{
    public partial class FormAsignarEspecieTamano : Form
    {
        private readonly CN_Especie _cnEspecie = new CN_Especie();
        private readonly CN_Tamano _cnTamano = new CN_Tamano(); 
        private readonly CN_EspecieTamano _cnEspecieTamano = new CN_EspecieTamano();
        private readonly ErrorProvider _ep = new ErrorProvider();

        public FormAsignarEspecieTamano()
        {
            InitializeComponent();
        }

        private void FormAsignarEspecieTamano_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            CargarDesplegables();
        }

        private void ConfigurarControles()
        {
            // Configuración del ErrorProvider
            _ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _ep.Icon = SystemIcons.Warning;
            _ep.SetIconAlignment(cbxEspecie, ErrorIconAlignment.MiddleRight);
            _ep.SetIconPadding(cbxEspecie, -20);
            _ep.SetIconAlignment(cbxTamano, ErrorIconAlignment.MiddleRight);
            _ep.SetIconPadding(cbxTamano, -20);
        }

        private void CargarDesplegables()
        {
            try
            {
                // Cargar Especies Activas
                List<Especie> especiesActivas = _cnEspecie.ListarEspecies()
                        .Where(e => e.Estado).ToList();
                especiesActivas.Insert(0, new Especie { IdEspecie = 0, Nombre = "-- Seleccione Especie --" });

                cbxEspecie.SelectedIndexChanged -= CbxEspecie_SelectedIndexChanged;
                cbxEspecie.DataSource = especiesActivas;
                cbxEspecie.DisplayMember = nameof(Especie.Nombre);
                cbxEspecie.ValueMember = nameof(Especie.IdEspecie);
                cbxEspecie.SelectedIndex = 0;
                cbxEspecie.SelectedIndexChanged += CbxEspecie_SelectedIndexChanged;

                // Cargar Tamaños Activos
                List<Tamano> tamanosActivos = _cnTamano.ListarTamanos()
                    .Where(t => t.Estado).ToList();
                tamanosActivos.Insert(0, new Tamano { IdTamano = 0, Nombre = "-- Seleccione Tamaño --" });

                cbxTamano.SelectedIndexChanged -= CbxTamano_SelectedIndexChanged;
                cbxTamano.DataSource = tamanosActivos;
                cbxTamano.DisplayMember = nameof(Tamano.Nombre);
                cbxTamano.ValueMember = nameof(Tamano.IdTamano);
                cbxTamano.SelectedIndex = 0;
                cbxTamano.SelectedIndexChanged += CbxTamano_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar catálogos maestros: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEspecie.SelectedValue is int id && id > 0)
            {
                _ep.SetError(cbxEspecie, string.Empty);
            }
        }

        private void CbxTamano_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTamano.SelectedValue is int id && id > 0)
            {
                _ep.SetError(cbxTamano, string.Empty);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            _ep.Clear();

            int idEspecie = cbxEspecie.SelectedValue != null ? Convert.ToInt32(cbxEspecie.SelectedValue) : 0;
            int idTamano = cbxTamano.SelectedValue != null ? Convert.ToInt32(cbxTamano.SelectedValue) : 0;

            bool hayError = false;

            if (idEspecie <= 0)
            {
                _ep.SetError(cbxEspecie, "Debe seleccionar una especie válida.");
                hayError = true;
            }

            if (idTamano <= 0)
            {
                _ep.SetError(cbxTamano, "Debe seleccionar un tamaño válido.");
                hayError = true;
            }

            if (hayError) return;

            bool exito = _cnEspecieTamano.AsignarRelacion(idEspecie, idTamano, out string mensaje);

            if (exito)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Validación de Negocio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
