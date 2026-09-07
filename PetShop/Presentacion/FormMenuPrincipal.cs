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
    public partial class FormMenuPrincipal : Form
    {
        // Variable para rastrear el formulario secundario actualmente visible
        private Form formularioActivo = null;

        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Muestra la hora en formato 24hs (HH:mm:ss)
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");

            // Muestra la fecha completa: día de la semana, día de mes de año
            DateTime ahora = DateTime.Now;

            // Obtiene y capitaliza el día de la semana 
            string diaSemana = ahora.ToString("dddd");
            diaSemana = char.ToUpper(diaSemana[0]) + diaSemana.Substring(1);

            // Obtiene y capitaliza el mes 
            string mes = ahora.ToString("MMMM");
            mes = char.ToUpper(mes[0]) + mes.Substring(1);

            lblFecha.Text = $"{diaSemana}, {ahora.Day} de {mes} de {ahora.Year}";
        }

        private void AbrirFormularioEnMdi<T>() where T : Form, new()
        {
            // Si ya está abierto el mismo formulario, no recarga
            if (formularioActivo != null && formularioActivo is T)
            {
                formularioActivo.BringToFront();
                return;
            }

            // Cierra y libera el formulario anterior si existe
            if (formularioActivo != null)
            {
                formularioActivo.Close();
                formularioActivo.Dispose();
            }

            formularioActivo = new T
            {
                TopLevel= false,
                FormBorderStyle = FormBorderStyle.None, 
                StartPosition = FormStartPosition.CenterScreen 
            };

            contenedor.Controls.Clear();
            contenedor.Controls.Add(formularioActivo);
            contenedor.Tag = formularioActivo;
            formularioActivo.Show();
            formularioActivo.BringToFront();
        }
        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormUsuarios>();
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormProductos>();
        }

       /* 
        * private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        * {
        * AbrirFormularioEnMdi<FormCategorias>();
        * } 
        */

        /*
        private void especiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormEspecies>();
        }
        */

        private void nuevaVentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormVentas>();
        }

        /*
        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormHistorialVentas>();
        }
        */

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormProovedores>();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormLogin>();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea cerrar la sesión actual?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
            "¿Está seguro de que desea salir del sistema?",
            "Confirmar Salida",
            MessageBoxButtons.YesNo,
            icon: MessageBoxIcon.Warning
        );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
