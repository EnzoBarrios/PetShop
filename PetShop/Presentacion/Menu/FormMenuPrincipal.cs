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
using PetShop.Presentacion.Usuarios;

namespace PetShop.Presentacion.Menu
{
    public partial class FormMenuPrincipal : Form
    {
        // Variable para almacenar el usuario actual
        private Usuario _usuarioActual;

        // Variable para rastrear el formulario secundario actualmente visible
        private Form _formularioActivo = null;

        public FormMenuPrincipal(Usuario usuario)
        {
            InitializeComponent();

            _usuarioActual = usuario;
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            ConfigurarPermisosPorRol();
        }

        private void CargarDatosUsuario()
        {
            if (_usuarioActual != null)
            {
                lblUsuarioLogueado.Text = _usuarioActual.NombreUsuario;

                if (_usuarioActual.Rol != null)
                {
                    lblRolLogeado.Text = _usuarioActual.Rol.NombreRol;
                }
            }
        }

        private void ConfigurarPermisosPorRol()
        {
            if (_usuarioActual?.Rol == null) return;

            string rol = _usuarioActual.Rol.NombreRol.Trim();

            usuariosToolStripMenuItem.Enabled = false;
            catalogoToolStripMenuItem.Enabled = false;
            ventaToolStripMenuItem.Enabled = false;
            reportesToolStripMenuItem.Enabled = false;

            switch (rol)
            {
                case "Administrador":
                    usuariosToolStripMenuItem.Enabled = true;
                    catalogoToolStripMenuItem.Enabled = true;
                    ventaToolStripMenuItem.Enabled = true;
                    reportesToolStripMenuItem.Enabled = true;
                    break;

                case "Gerente":
                    // El gerente no administra usuarios del sistema
                    catalogoToolStripMenuItem.Enabled = true;
                    ventaToolStripMenuItem.Enabled = true;
                    reportesToolStripMenuItem.Enabled = true;
                    break;

                case "Vendedor":
                    // El vendedor solo opera ventas y consulta productos
                    catalogoToolStripMenuItem.Enabled = true;
                    ventaToolStripMenuItem.Enabled = true;
                    break;

                default:
                    // Por seguridad, si el rol no coincide se oculta todo lo crítico
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
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
            if (_formularioActivo != null && _formularioActivo is T)
            {
                _formularioActivo.BringToFront();
                return;
            }

            if (_formularioActivo != null)
            {
                _formularioActivo.Close();
                _formularioActivo.Dispose();
            }

            _formularioActivo = new T
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.None // <--- Esto hace que el formulario tome todo el tamaño del contenedor
            };

            // Calcula el centrado respecto al tamaño interno del contenedor
            int posicionX = Math.Max(0, (contenedor.ClientSize.Width - _formularioActivo.Width) / 2);
            int posicionY = Math.Max(0, (contenedor.ClientSize.Height - _formularioActivo.Height) / 2);

            _formularioActivo.Location = new Point(posicionX, posicionY);

            contenedor.Controls.Clear();
            contenedor.Controls.Add(_formularioActivo);
            contenedor.Tag = _formularioActivo;

            _formularioActivo.Show();
            _formularioActivo.BringToFront();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormUsuarios>();
        } 

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormHistorialVentas>();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormReportes>();
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
                this.Close();
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
