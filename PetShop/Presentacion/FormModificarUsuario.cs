using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FormModificarUsuario : Form
    {
        // Instancia del ErrorProvider para validaciones visuales
        private ErrorProvider ep = new ErrorProvider();

        public FormModificarUsuario()
        {
            InitializeComponent();
        }

        private void FormModificarUsuario_Load(object sender, EventArgs e)
        {
            // Cargar la fecha de creación por defecto en el Label o DateTimePicker deshabilitado
            //LFechaCreacion.Text = DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy");

            // Configurar los desplegables para que no permitan escritura manual de texto
            CBRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CBEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool ValidarFormulario()
        {
            ep.Clear(); // Limpiar errores anteriores
            bool esValido = true;

            // Nombre: Obligatorio
            if (string.IsNullOrWhiteSpace(TNombre.Text))
            {
                ep.SetError(TNombre, "El nombre es obligatorio.");
                esValido = false;
            }

            // Apellido: Obligatorio
            if (string.IsNullOrWhiteSpace(TApellido.Text))
            {
                ep.SetError(TApellido, "El apellido es obligatorio.");
                esValido = false;
            }

            // Nombre de Usuario: Obligatorio y mínimo 4 caracteres
            if (string.IsNullOrWhiteSpace(TNombreUsuario.Text))
            {
                ep.SetError(TNombreUsuario, "El nombre de usuario es obligatorio.");
                esValido = false;
            }
            else if (TNombreUsuario.Text.Trim().Length < 4)
            {
                ep.SetError(TNombreUsuario, "Debe tener al menos 4 caracteres.");
                esValido = false;
            }

            // Contraseña: Solo si se escribe algo (modificación opcional)
            bool contrasenaEscrita = !string.IsNullOrWhiteSpace(TClave.Text);

            if (contrasenaEscrita)
            {
                if (TClave.Text.Length < 6)
                {
                    ep.SetError(TClave, "La contraseña debe tener al menos 6 caracteres.");
                    esValido = false;
                }

                // Confirmar Contraseña: Debe coincidir con Contraseña
                if (TConfirmar.Text != TClave.Text)
                {
                    ep.SetError(TConfirmar, "Las contraseñas no coinciden.");
                    esValido = false;
                }
            }

            // Rol: Selección obligatoria
            if (CBRol.SelectedIndex == -1 || CBRol.SelectedItem == null)
            {
                ep.SetError(CBRol, "Debe seleccionar un rol.");
                esValido = false;
            }

            // Estado: Selección obligatoria
            if (CBEstado.SelectedIndex == -1 || CBEstado.SelectedItem == null)
            {
                ep.SetError(CBEstado, "Debe seleccionar un estado.");
                esValido = false;
            }

            return esValido;
        }

        // --- EVENTOS DE BOTONES ---

        // Botón Guardar
        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                return; // Corta la ejecución si hay errores de validación
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea guardar los cambios del usuario?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                // TODO: Aquí va el código para actualizar en la Base de Datos

                MessageBox.Show("Usuario modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // Botón Eliminar todo (Limpiar Formulario)
        private void BEliminarTodo_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show(
                "¿Desea blanquear todos los campos del formulario?",
                "Limpiar campos",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                LimpiarCampos();
            }
        }

        // Método auxiliar para limpiar todos los campos del formulario
        private void LimpiarCampos()
        {
            TNombre.Clear();
            TApellido.Clear();
            TNombreUsuario.Clear();
            TClave.Clear();
            TConfirmar.Clear();

            CBRol.SelectedIndex = -1;
            CBEstado.SelectedIndex = -1;

            ep.Clear();
            TNombre.Focus();
        }

        // Botón Volver
        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LFecha_Click(object sender, EventArgs e)
        {

        }
    }
}