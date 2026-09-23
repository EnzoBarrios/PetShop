using PetShop.Entidades;
using PetShop.Presentacion.Catalogos;
using PetShop.Presentacion.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Presentacion.Menu
{
    public partial class FormMenuPrincipal : Form
    {
        // Variable para almacenar el usuario actual
        private readonly Usuario _usuarioActual;

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

        private void FormMenuPrincipal_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null; // Desactiva el enfoque inicial en cualquier control
        }

        private void CargarDatosUsuario()
        {
            if (_usuarioActual != null)
            {
                lblUsuarioLogueado.Text = _usuarioActual.NombreUsuario;
                lblUsuarioBienvenida.Text = $"¡Bienvenido: {_usuarioActual.Apellido} {_usuarioActual.Nombre}!";

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

            UsuariosToolStripMenuItem.Enabled = false;
            CatalogoToolStripMenuItem.Enabled = false;
            VentaToolStripMenuItem.Enabled = false;
            ReportesToolStripMenuItem.Enabled = false;

            switch (rol)
            {
                case "Administrador":
                    UsuariosToolStripMenuItem.Enabled = true;
                    CatalogoToolStripMenuItem.Enabled = true;
                    VentaToolStripMenuItem.Enabled = true;
                    ReportesToolStripMenuItem.Enabled = true;
                    break;

                case "Gerente":
                    // El gerente no administra usuarios del sistema
                    CatalogoToolStripMenuItem.Enabled = true;
                    VentaToolStripMenuItem.Enabled = true;
                    ReportesToolStripMenuItem.Enabled = true;
                    break;

                case "Vendedor":
                    // El vendedor solo opera ventas y consulta productos
                    CatalogoToolStripMenuItem.Enabled = true;
                    VentaToolStripMenuItem.Enabled = true;
                    break;

                default:
                    // Por seguridad, si el rol no coincide se oculta todo lo crítico
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
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
            // Si ya está abierto el mismo formulario y sigue, se trae al frente
            if (_formularioActivo != null && !_formularioActivo.IsDisposed && _formularioActivo is T)
            {
                _formularioActivo.BringToFront();
                return;
            }

            // Si había otro formulario secundario abierto, se cierra
            if (_formularioActivo != null && !_formularioActivo.IsDisposed)
            {
                contenedor.Controls.Remove(_formularioActivo);
                _formularioActivo.Close();
                _formularioActivo = null;
            }

            // Crea una nueva instancia del formulario secundario
            T nuevoFormulario = new T
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.None
            };

            // Cuando el formulario se cierre con el boton volver
            nuevoFormulario.FormClosed += (s, args) =>
            {
                if (_formularioActivo == s)
                {
                    _formularioActivo = null;
                }
            };

            // Calcula el centrado respecto al tamaño interno del contenedor
            int posicionX = Math.Max(0, (contenedor.ClientSize.Width - nuevoFormulario.Width) / 2);
            int posicionY = Math.Max(0, (contenedor.ClientSize.Height - nuevoFormulario.Height) / 2);
            nuevoFormulario.Location = new Point(posicionX, posicionY);

            _formularioActivo = nuevoFormulario;        // Asigna el formulario activo
            contenedor.Tag = _formularioActivo;         // Almacena la referencia del formulario activo en el Tag del contenedor
            contenedor.Controls.Add(_formularioActivo); // Agrega el formulario al contenedor
            _formularioActivo.BringToFront();           // Asegura que el formulario esté al frente
            _formularioActivo.Show();                   // Muestra el formulario secundario
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormUsuarios>();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormProductos>();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormCategorias>();
        }

        private void EspeciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormEspecies>();
        }

        private void NuevaVentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormVentas>();
        }

        private void HistorialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormHistorialVentas>();
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormReportes>();
        }

        private void CerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void BtnRealizarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormVentas>();
        }

        private void BtnHistorialVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormHistorialVentas>();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormReportes>();
        }
    }
}
