using ControlPanelConcerts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanelConcerts.ContextDb
{
    public class MyContext:DbContext
    {

        public DbSet<Instrumento> Instrumento{ get; set; }
        public DbSet<Musico> Musico{ get; set; }
        public DbSet<Concierto> Concierto{ get; set; }
        public DbSet<ConciertoMusico> ConciertoMusico { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

    }
}
