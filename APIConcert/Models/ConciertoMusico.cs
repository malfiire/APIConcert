using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanelConcerts.Models
{
    //clase necesaria para saber cuantos músicos tengo por concierto y asi poder calcular el total de gastos de un concierto
    public class ConciertoMusico
    {
        public int Id { get; set; }
        public int ConciertoId { get; set; }
        public int MusicoId { get; set; }
        public virtual Concierto Concierto { get; set; }
        public virtual Musico Musico { get; set; }
    }
}
