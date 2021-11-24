namespace Domus.Models
{
    public class Corporativo : Cliente
    {

        private string _domicilio;
        private string _nacionalidad;
        private string _razonSocial;
        private string _cuit;

        public string CUIT
        {
            get { return _cuit; }
            set { _cuit = value; }
        }

        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }
        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }
    }
}
