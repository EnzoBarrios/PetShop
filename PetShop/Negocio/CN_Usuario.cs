using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Datos;
using PetShop.Entidades;

namespace PetShop.Negocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }
    }
}
