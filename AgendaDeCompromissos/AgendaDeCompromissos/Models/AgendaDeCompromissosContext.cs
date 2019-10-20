using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaDeCompromissos.Models
{
    public class AgendaDeCompromissosContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Agenda> Agendas { get; set; }
    }
}
