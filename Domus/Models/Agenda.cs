using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domus.Models
{
    public class Agenda
    {
        public Agenda()
        {
            Citas = new HashSet<Cita>();
        }
        [Key]
        public int IdAgenda { get; set; }
        public virtual ICollection<Cita> Citas { get; set; }
        public virtual Calendario Calendario { get; set; }
    }
}
