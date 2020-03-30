using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Final_progIII.Models
{
    public class MedicosContext: DbContext
    {
        public MedicosContext()
            : base("Brey")
        {
        }
        public DbSet<Medicos> Medicoss { get; set; }
        public DbSet<Pacientes> Pacientess { get; set; }

    }
}