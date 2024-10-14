namespace Ambev.Domain.Entities
{
    public class VendaProduto : BaseEntity
    {
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto? Produto { get; set; }
    }
}
