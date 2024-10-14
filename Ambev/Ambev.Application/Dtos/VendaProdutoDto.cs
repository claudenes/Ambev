using Ambev.Domain.Entities;

namespace Ambev.Application.Dtos
{
    public class VendaProdutoDto
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public virtual ProdutoDto? Produto { get; set; }
    }
}
