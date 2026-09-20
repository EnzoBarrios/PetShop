using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class Especie
    {
        // Atributos directos de la tabla Especie
        public int IdEspecie { get; set; } // Clave primaria de la tabla Especie
        public string NombreEspecie { get; set; }

        // Constructor vacío
        public Especie()
        {
        }

        // Constructor con parámetros
        public Especie(int idEspecie, string nombreEspecie)
        {
            IdEspecie = idEspecie;
            NombreEspecie = nombreEspecie;
        }
    }
}
