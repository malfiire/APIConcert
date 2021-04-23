using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanelConcerts.Models
{
    public class Instrumento
    {
        public int Id { get; set; }
        public string NombreInstrumento { get; set; }   
        public string TipoInstrumento { get; set; }
        public string MarcaInstrumento { get; set; }
        public int PrecioInstrumento { get; set; }
        public int Cantidad { get; set; }

    }
}
