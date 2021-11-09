using System.ComponentModel.DataAnnotations;

namespace Domus.ViewModels
{
    public class CitaView
    {
        public Cliente Cliente { get; set; }    
        public Cita Cita { get; set; }
        public IList<Horarios> Horarios { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime? FechaBuscada { get; set; }
    }
}
