namespace Ambev.Domain.Entities
{
    public class Venda : BaseEntity
    {
        public DateTime DataVenda { get; set; }
        public double ValorTotalVenda { get; set; }
        public virtual Cliente Clientes { get; set; }
        public virtual List<Produto> Produtos { get; set; }
        public virtual Filial Filial { get; set; }

    }
}
