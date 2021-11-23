namespace Domus.Models
{
    public class Corporativo : Cliente
    {
        public string Domicilio { get; set; }
        public string Nacionalidad { get; set; }
        public string RazonSocial { get; set; }
        public string CUIT { get; set; }
    }
}
