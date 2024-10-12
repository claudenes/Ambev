namespace Ambev.Domain.Entities
{
    public class Produto : BaseEntity
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }
    }
}
