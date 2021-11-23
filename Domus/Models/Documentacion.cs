namespace Domus.Models
{
    public class Documentacion
    {
        [Key]
        public int IdDocumentacion { get; set; }
        public string Descripcion { get; set; }
        public TipoDocumentacion MyProperty { get; set; }
    }
}