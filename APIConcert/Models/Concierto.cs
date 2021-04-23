using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanelConcerts.Models
{
    public class Concierto
    {
        public int Id { get; set; }
        public string NombreConcierto { get; set; }
        public DateTime FechaConcierto { get; set; }

    }
}
