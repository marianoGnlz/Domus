namespace Domus.Models
{
    public class Particular : Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string CUIL { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime FechaDeNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
