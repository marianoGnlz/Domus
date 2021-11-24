namespace Domus.Models
{
    public class Particular : Cliente
    {
        private string _nombre;
        private string _apellido;
        private string _dni;
        private string _cuil;
        private DateTime _fechaDeNacimiento;
        private string _telefono;
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime FechaDeNacimiento
        {
            get { return _fechaDeNacimiento; }
            set { _fechaDeNacimiento = value; }
        }
        public string CUIL
        {
            get { return _cuil; }
            set { _cuil = value; }
        }
        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
