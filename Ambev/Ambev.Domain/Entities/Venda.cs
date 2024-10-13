namespace Ambev.Domain.Entities
{
    public class Venda : BaseEntity
    {
        public DateTime DataVenda { get; set; }
        public double ValorTotalVenda { get; set; }
        public int ClienteId { get; set; }
        public int FilialId { get; set; }
        public bool Cancelado { get; set; }
        public virtual List<VendaProduto>? VendaProduto { get; set; }

        public virtual Cliente? Cliente { get; set; }
        public virtual Filial? Filial { get; set; }

    }
}
