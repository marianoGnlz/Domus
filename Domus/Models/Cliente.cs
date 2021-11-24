namespace Domus.Models
{
    public abstract class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public int NroCuenta { get; set; }
        public TipoCliente TipoCliente { get; set; }

    }
}
