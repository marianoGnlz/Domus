using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.Models
{
    public class Cita
    {
        [Key]
        public int IdCita { get; set; }
        private DateTime fecha;
        private TimeSpan hora;

        public TimeSpan Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public virtual Cliente Cliente { get; set; }

    }
}
