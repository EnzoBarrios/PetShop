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
    public partial class FormModificarProducto : Form
    {
        private int idProducto;
        
        // 1. Constructor sin parámetros (por defecto)
        public FormModificarProducto()
        {
            InitializeComponent();
        }

        // 2. Constructor con parámetro (recibe el ID)
        // Llama primero al constructor sin parámetros y luego ejecuta su propio cuerpo
        public FormModificarProducto(int idProducto) : this()
        {
            this.idProducto = idProducto;
        }

        private void FormModificarProducto_Load(object sender, EventArgs e)
        {

        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
