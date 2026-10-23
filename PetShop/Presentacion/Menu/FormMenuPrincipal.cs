using PetShop.Entidades;
using PetShop.Negocio;
using PetShop.Presentacion.Catalogos;
using PetShop.Presentacion.Usuarios;
using PetShop.Presentacion.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PetShop.Presentacion.Menu
{
    public partial class FormMenuPrincipal : Form
    {
        private Usuario _usuarioActual; // Variable para almacenar el usuario actual
        
        private Form _formularioActivo;// Variable para rastrear el formulario secundario actualmente visible

        private readonly CN_Usuario _cnUsuario;

        public FormMenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            _usuarioActual = usuario ?? throw new ArgumentNullException(nameof(usuario));
            _cnUsuario = new CN_Usuario();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            contenedor.AutoScroll = true;
            contenedor.AutoScrollMargin = new Size(10, 20); // Agrega 20px de margen vertical inferior extra
            CargarDatosUsuario();
            ConfigurarPermisosPorRol();
        }

        private void FormMenuPrincipal_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null; // Desactiva el enfoque inicial en cualquier control
        }

        public void RefrescarDatosUsuario()
        {
            if (_usuarioActual == null)
            {
                return;
            }

            try 
            { 
                // Recarga los datos frescos de la BD a través de la capa de negocio
                Usuario usuarioActualizado = _cnUsuario.ObtenerPorId(_usuarioActual.IdUsuario);

                if (usuarioActualizado != null)
                {
                    _usuarioActual = usuarioActualizado;
                    CargarDatosUsuario();
                    ConfigurarPermisosPorRol();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al sincronizar datos del perfil: {ex.Message}",
                                "Error de Sincronización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosUsuario()
        {
            if (_usuarioActual == null)
            {
                return;
            }

            lblUsuarioLogueado.Text = _usuarioActual.NombreUsuario;
            lblUsuarioBienvenida.Text = $"¡Bienvenido: {_usuarioActual.Apellido} {_usuarioActual.Nombre}!";
            lblRolLogeado.Text = _usuarioActual.Rol?.NombreRol ?? "Sin Rol";
        }

        private void ConfigurarPermisosPorRol()
        {
            if (_usuarioActual.Rol == null) return;

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
                case CN_Rol.ROL_ADMINISTRADOR:
                    UsuariosToolStripMenuItem.Enabled = true;
                    CatalogoToolStripMenuItem.Enabled = true;
                    VentaToolStripMenuItem.Enabled = true;
                    ReportesToolStripMenuItem.Enabled = true;

                    btnHistorialVentas.Enabled = true;
                    btnReportes.Enabled = true;

                    NuevaVentaToolStripMenuItem.Enabled = false;
                    break;

                case CN_Rol.ROL_GERENTE:
                    // El gerente supervisa ventas, catálogos y reportes
                    UsuariosToolStripMenuItem.Enabled = true;
                    CatalogoToolStripMenuItem.Enabled = true;
                    VentaToolStripMenuItem.Enabled = true;
                    ReportesToolStripMenuItem.Enabled = true;

                    btnRealizarVenta.Enabled = true;
                    btnHistorialVentas.Enabled = true;
                    btnReportes.Enabled = true;
                    break;

                case CN_Rol.ROL_VENDEDOR:
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
            if (nuevoFormulario == null)
            {
                MessageBox.Show("No se pudo inicializar la ventana solicitada.",
                                "Error de Navegación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contenedor == null)
            {
                MessageBox.Show("El contenedor visual principal no está disponible.",
                                "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_formularioActivo != null &&
               !_formularioActivo.IsDisposed &&
                _formularioActivo.GetType() == nuevoFormulario.GetType())
            {
                _formularioActivo.BringToFront();
                nuevoFormulario.Dispose();
                return;
            }

            contenedor.SuspendLayout();

            try
            {
                if (_formularioActivo != null && !_formularioActivo.IsDisposed)
                {
                    Form formularioAnterior = _formularioActivo;
                    _formularioActivo = null;

                    formularioAnterior.FormClosed -= FormularioHijo_FormClosed;

                    contenedor.Controls.Remove(formularioAnterior);
                    formularioAnterior.Close();
                    formularioAnterior.Dispose();
                }

                nuevoFormulario.TopLevel = false;
                nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
                nuevoFormulario.Dock = DockStyle.None;
                nuevoFormulario.Location = new Point(0, 0);

                // Permite que el formulario reconozca el tamaño real de sus controles
                nuevoFormulario.AutoSize = true;
                nuevoFormulario.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                nuevoFormulario.FormClosed += FormularioHijo_FormClosed;

                _formularioActivo = nuevoFormulario;
                contenedor.Controls.Add(_formularioActivo);

                // Fuerza a calcular el diseño antes de medir el tamaño
                _formularioActivo.PerformLayout();

                // Le asigna al panel el tamaño exacto requerido por el formulario
                contenedor.AutoScrollMinSize = _formularioActivo.PreferredSize;

                _formularioActivo.Show();
                _formularioActivo.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar la vista: {ex.Message}",
                                "Error de Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                contenedor.ResumeLayout(true);
            }
        }
        
        private void FormularioHijo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender is Form formCerrado)
            {
                formCerrado.FormClosed -= FormularioHijo_FormClosed;

                if (_formularioActivo == formCerrado)
                {
                    _formularioActivo = null;
                }
            }

            this.ActiveControl = null;
        }

        // Sobrecarga genérica para formularios sin parámetros
        private void AbrirFormularioEnMdi<T>() where T : Form, new()
        {
            AbrirFormularioEnMdi(new T());
        }

        // ACCIONES DE MENÚ Y ACCESOS DIRECTOS
        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = _usuarioActual?.IdUsuario ?? 0;
            string rol = _usuarioActual?.Rol?.NombreRol ?? string.Empty;

            AbrirFormularioEnMdi(new FormUsuarios(id, rol));
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormProductos>();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormCategoria>();
        }

        private void EspeciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormEspecieTamano>();
        }

        private void NuevaVentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi(new FormRegistrarVenta(_usuarioActual));
        }

        private void HistorialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormHistorialVentas>();
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormReportes>();
        }

        private void BtnRealizarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi(new FormRegistrarVenta(_usuarioActual));
        }

        private void BtnHistorialVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormHistorialVentas>();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnMdi<FormReportes>();
        }

        private void MiPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idUsuarioActual = _usuarioActual?.IdUsuario ?? 0;

            if (idUsuarioActual > 0)
            {
                FormMiPerfil formMiPerfil = new FormMiPerfil(idUsuarioActual);
                formMiPerfil.FormClosed += (s, args) =>
                {
                    RefrescarDatosUsuario();
                };

                AbrirFormularioEnMdi(formMiPerfil);
            }
            else
            {
                MessageBox.Show("No se pudo obtener el ID del usuario actual.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        
    }
}
