using Bogus;
using Ambev.Application.Dtos;
using Ambev.Domain.Entities;

namespace Ambev.Domain.Tests.Domain
{
    internal class GenerateFakerVendaDto
    {
        private static Faker<VendaDto> CreateVendaDtoFaker()
        {
            return new Faker<VendaDto>().StrictMode(true)
            .RuleFor(x => x.Id, f => f.Random.Int())
            .RuleFor(x => x.ClienteId, f => f.Random.Int())
            .RuleFor(x => x.FilialId, f => f.Random.Int())
            .RuleFor(x => x.DataVenda, f => f.Date.Past())
            .RuleFor(x => x.Cancelado, f => true)
            .RuleFor(x => x.ValorTotalVenda, f => f.Random.Decimal())
            .RuleFor(x => x.Cliente, f => new ClienteDto())
            .RuleFor(x => x.Filial, f => new FilialDto())
            .RuleFor(x => x.VendaProduto, f => new List<VendaProdutoDto>());

        }
        private static Faker<Venda> CreateVendaFaker(VendaDto cliente)
        {
            return new Faker<Venda>().StrictMode(true)
            .RuleFor(x => x.Id, f => cliente.Id)
            .RuleFor(x => x.ClienteId, f => cliente.ClienteId)
            .RuleFor(x => x.FilialId, f => cliente.FilialId)
            .RuleFor(x => x.DataVenda, f => cliente.DataVenda)
            .RuleFor(x => x.Cancelado, f => cliente.Cancelado)
            .RuleFor(x => x.ValorTotalVenda, f => cliente.ValorTotalVenda)
            .RuleFor(x => x.Cliente, new Cliente())
            .RuleFor(x => x.Filial, new Filial())
            .RuleFor(x => x.VendaProduto, new List<VendaProduto>());
        }
        public static VendaDto CreateVendaDto()
        {
            return CreateVendaDtoFaker().Generate(); 
        }
        public static Venda CreateVenda(VendaDto venda)
        {
            return CreateVendaFaker(venda).Generate();
        }
        public static IEnumerable<Venda> CreateIEnumerableVenda(VendaDto venda, int count)
        {
            return CreateVendaFaker(venda).Generate(count);
        }
    }
}
