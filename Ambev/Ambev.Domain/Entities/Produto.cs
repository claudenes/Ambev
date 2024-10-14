namespace Ambev.Domain.Entities
{
    public class Produto : BaseEntity
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public virtual List<VendaProduto>? VendaProduto { get; set; }
    }
}
