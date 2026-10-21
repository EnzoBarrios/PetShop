using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Entidades
{
    public class Reporte
    {
        public int NroTicket { get; set; }
        public DateTime Fecha { get; set; }
        public string Producto { get; set; }
        public string Categoria { get; set; }
        public int Especie { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }

        public Reporte() { }
    }
}
