namespace Domus.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string nombreApre { get; set; }
        public DateTime FechaNac { get; set; }
        public int Nrocuenta { get; set; }
        public TipoEmpleado Tipo { get; set; }
        public string telefono { get; set; }
    }
}
