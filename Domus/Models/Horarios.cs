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
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        private TimeSpan horario;
        private bool disponible;

        public bool Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }


        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public TimeSpan Horario
        {
            get { return horario; }
            set { horario = value; }
        }

    }
}
