using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.Models
{
    public class Calendario
    {
        public Calendario()
        {
            Horarios = new HashSet<Horarios>();
        }
        [Key]
        public int IdCalendario { get; set; }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public virtual ICollection<Horarios> Horarios { get; set; }

    }
}
