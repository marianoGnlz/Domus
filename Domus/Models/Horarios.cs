using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.Models
{
    public class Horarios
    {
        [Key]
        public int IdHorarios { get; set; }
        private TimeSpan horario;

        public TimeSpan Horario
        {
            get { return horario; }
            set { horario = value; }
        }

    }
}
