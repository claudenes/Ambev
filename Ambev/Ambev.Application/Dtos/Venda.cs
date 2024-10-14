using Ambev.Domain.Entities;

namespace Ambev.Application.Dtos
{
    public class VendaDto
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotalVenda { get; set; }
        public int ClienteId { get; set; }
        public int FilialId { get; set; }
        public bool Cancelado { get; set; }
        public virtual List<VendaProdutoDto>? VendaProduto { get; set; }

        public virtual ClienteDto? Cliente { get; set; }
        public virtual FilialDto? Filial { get; set; }

    }
}
