using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaDeCompromissos.Models
{
    [Table("Agendas")]
    public class Agenda
    {
        [Key]
        public int Id { get; set; }

        public int IdPaciente { get; set; }
        
        public Paciente Paciente { get; set; }

        [Required]
        public DateTime DataInicial { get; set; }

        [Required]
        public DateTime DataFinal { get; set; }

        public string Observacao { get; set; }
    }
}
