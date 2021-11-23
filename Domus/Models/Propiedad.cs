namespace Domus.Models
{
    public class Propiedad
    {
        [Key]
        public int IdPropiedad { get; set; }
        public int Antiguedad { get; set; }
        public int CantHabitaciones { get; set; }
        public string Espacios { get; set; }
        public string Servicios { get; set; }
        public int CantBanios { get; set; }
        public string Artefactos { get; set; }
    }
}
