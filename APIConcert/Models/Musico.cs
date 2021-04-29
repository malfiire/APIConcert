using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanelConcerts.Models
{
    public class Musico
    {
        public int Id { get; set; }
        public string NombreMusico { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int SueldoMusico { get; set; }
        public int InstrumentoId{ get; set; }
        public virtual Instrumento Instrumento { get; set; }
        

    }
}
