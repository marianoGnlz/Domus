namespace Domus.Models
{
    public abstract class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public int NroCuenta { get; set; }
        public Documentacion Documentacion { get; set; }
        public Propiedad Propiedad { get; set; }
    }
}
