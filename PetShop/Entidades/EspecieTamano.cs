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
        public bool Estado { get; set; }

        // Objetos completos para tener acceso a los nombres
        public Especie Especie { get; set; }    // Objeto completo para tener acceso al nombre de la especie
        public Tamano Tamano { get; set; }      // Objeto completo para tener acceso al nombre del tamaño

        public string NombreEspecie => Especie?.Nombre ?? string.Empty;
        public string NombreTamano => Tamano?.Nombre ?? string.Empty;

        // Constructor vacío
        public EspecieTamano()
        {
            Especie = new Especie();  // Inicializa el objeto Especie para evitar referencias nulas
            Tamano = new Tamano();    // Inicializa el objeto Tamano para evitar referencias nulas
            Estado = true;
        }

        // Constructor con parámetros
        public EspecieTamano(int idEspecie, int idTamano, bool estado = true)
        {
            IdEspecie = idEspecie;
            IdTamano = idTamano;
            Estado = estado;
            Especie = new Especie { IdEspecie = idEspecie };
            Tamano = new Tamano { IdTamano = idTamano };
        }
    }
}
