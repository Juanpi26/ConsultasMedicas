using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Final_progIII.Models
{
    public class PacientesContext: DbContext
    {

        public DbSet<Pacientes> Pacientess { get; set; }

    }
}