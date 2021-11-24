namespace Domus.Models
{
    public abstract class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        private int _nroCuenta;
        private TipoCliente _tipoCliente;


        public int NroCuenta
        {
            get { return _nroCuenta; }
            set { _nroCuenta = value; }
        }
        public TipoCliente TipoCliente
        {
            get { return _tipoCliente; }
            set { _tipoCliente = value; }
        }

    }
}
