namespace Ambev.Application.Dtos
{
    public class VendaDto
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public double ValorTotalVenda { get; set; }
        public virtual ClienteDto Clientes { get; set; }
        public virtual List<ProdutoDto> Produtos { get; set; }
        public virtual FilialDto Filial { get; set; }

    }
}
