using Ambev.Domain.Entities;

namespace Ambev.Application.Dtos
{
    public class ProdutoDto 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }
        public virtual List<VendaProdutoDto>? VendaProduto { get; set; }
    }
}
