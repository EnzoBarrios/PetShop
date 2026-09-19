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
        private CD_Usuario _cdusuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return _cdusuario.Listar();
        }
    }
}
