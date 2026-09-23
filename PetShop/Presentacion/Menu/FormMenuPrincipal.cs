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
        private readonly Usuario _usuarioActual; // Variable para almacenar el usuario actual
        
        private Form _formularioActivo = null;// Variable para rastrear el formulario secundario actualmente visible

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
            if (_usuarioActual == null || _usuarioActual.Rol == null) return;

            string rol = _usuarioActual.Rol.NombreRol.Trim();

            // 1. Apagado preventivo de menús
            UsuariosToolStripMenuItem.Enabled = false;
            CatalogoToolStripMenuItem.Enabled = false;
            VentaToolStripMenuItem.Enabled = false;
            ReportesToolStripMenuItem.Enabled = false;

            // 2. Apagado preventivo de accesos directos
            btnRealizarVenta.Enabled = false;
            btnHistorialVentas.Enabled = false;
            btnReportes.Enabled = false;

            // 3. Activación según perfil
            switch (rol)
            {
                case "Administrador":
                    UsuariosToolStripMenuItem.Enabled = true;
                    CatalogoToolStripMenuItem.Enabled = true;
                    VentaToolStripMenuItem.Enabled = true;
                    ReportesToolStripMenuItem.Enabled = true;

                    btnHistorialVentas.Enabled = true;
                    btnReportes.Enabled = true;

                    NuevaVentaToolStripMenuItem.Enabled = false;
                    break;

                case "Gerente":
                    // El gerente supervisa ventas, catálogos y reportes
                    UsuariosToolStripMenuItem.Enabled = true;
                    CatalogoToolStripMenuItem.Enabled = true;
                    VentaToolStripMenuItem.Enabled = true;
                    ReportesToolStripMenuItem.Enabled = true;

                    btnRealizarVenta.Enabled = true;
                    btnHistorialVentas.Enabled = true;
                    btnReportes.Enabled = true;
                    break;

                case "Vendedor":
                    // El vendedor solo opera ventas y consulta productos
                    CatalogoToolStripMenuItem.Enabled = true;
                    VentaToolStripMenuItem.Enabled = true;

                    btnRealizarVenta.Enabled = true;
                    btnHistorialVentas.Enabled = true;
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


        // Método base que incrusta cualquier instancia de formulario
        private void AbrirFormularioEnMdi(Form nuevoFormulario)
        {
            // Si ya está abierto el mismo formulario y sigue, se trae al frente
            if (_formularioActivo != null && !_formularioActivo.IsDisposed && _formularioActivo.GetType() == nuevoFormulario.GetType())
            {
                _formularioActivo.BringToFront();
                nuevoFormulario.Dispose();
                return;
            }

            contenedor.SuspendLayout();

            try
            {
                // Si había otro formulario secundario abierto, se cierra
                if (_formularioActivo != null && !_formularioActivo.IsDisposed)
                {
                    contenedor.Controls.Remove(_formularioActivo);
                    _formularioActivo.Close();
                    _formularioActivo = null;
                }

                nuevoFormulario.TopLevel = false;
                nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
                nuevoFormulario.StartPosition = FormStartPosition.Manual;

                // Cuando el formulario se cierre con el boton volver
                nuevoFormulario.FormClosed += (s, args) =>
                {
                    if (_formularioActivo == s)
                    {
                        _formularioActivo = null;
                    }

                    this.ActiveControl = null;
                };

                _formularioActivo = nuevoFormulario;        // Asigna el formulario activo
                contenedor.Tag = _formularioActivo;         // Almacena la referencia del formulario activo en el Tag del contenedor
                contenedor.Controls.Add(_formularioActivo); // Agrega el formulario al contenedor
                _formularioActivo.Show();                   // Muestra el formulario secundario
                _formularioActivo.BringToFront();           // Asegura que el formulario esté al frente
            }
            finally
            {
                contenedor.ResumeLayout(true);
            }
        }

        // Sobrecarga genérica para formularios sin parámetros
        private void AbrirFormularioEnMdi<T>() where T : Form, new()
        {
            AbrirFormularioEnMdi(new T());
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pasa el ID y Rol del usuario logueado
            int id = _usuarioActual?.IdUsuario ?? 0;
            string rol = _usuarioActual?.Rol?.NombreRol ?? "Administrador";

            AbrirFormularioEnMdi(new FormUsuarios(id, rol));
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

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idUsuarioActual = _usuarioActual?.IdUsuario ?? 0;

            if (idUsuarioActual > 0)
            {
                AbrirFormularioEnMdi(new FormMiPerfil(idUsuarioActual));
            }
            else
            {
                MessageBox.Show("No se pudo obtener el ID del usuario actual.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
