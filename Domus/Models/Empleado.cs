namespace Domus.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }

        private string _nombreYApe;
        private DateTime _fechaDeNacimiento;
        private int _nroCuenta;
        private TipoEmpleado _tipo;
        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public TipoEmpleado Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public int NroCuenta
        {
            get { return _nroCuenta; }
            set { _nroCuenta = value; }
        }
        public DateTime FechaDeNacimiento
        {
            get { return _fechaDeNacimiento; }
            set { _fechaDeNacimiento = value; }
        }
        public string NombreYApe
        {
            get { return _nombreYApe; }
            set { _nombreYApe = value; }
        }
    }
}
