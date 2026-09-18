using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class EspecieTamano
    {
        // Claves foráneas que componen la tabla intermedia
        public int IdEspecie { get; set; }  // Clave foránea para la especie 
        public int IdTamano { get; set; }   // Clave foránea para el tamaño

        // Objetos completos para tener acceso a los nombres
        public Especie Especie { get; set; }    // Objeto completo para tener acceso al nombre de la especie
        public Tamano Tamano { get; set; }      // Objeto completo para tener acceso al nombre del tamaño

        // Constructor vacío
        public EspecieTamano()
        {
        }

        // Constructor con parámetros
        public EspecieTamano(int idEspecie, int idTamano)
        {
            IdEspecie = idEspecie;
            IdTamano = idTamano;
            Especie = new Especie { IdEspecie = idEspecie };
            Tamano = new Tamano { IdTamano = idTamano };
        }
    }
}
