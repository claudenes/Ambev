using Bogus;
using Ambev.Application.Dtos;
using Ambev.Domain.Entities;

namespace Ambev.Domain.Tests.Domain
{
    internal class GenerateFakerClienteDto
    {
        private static Faker<ClienteDto> CreateClienteDtoFaker()
        {
            return new Faker<ClienteDto>().StrictMode(true)
            .RuleFor(x => x.Id, f => f.Random.Int())
            .RuleFor(x => x.Nome, f => f.Name.FirstName())
            .RuleFor(x => x.CPF, f => f.Name.FirstName())
            .RuleFor(x => x.DataNascimento, f => f.Date.Past());
        }
        private static Faker<Cliente> CreateClienteFaker(ClienteDto cliente)
        {
            return new Faker<Cliente>().StrictMode(true)
            .RuleFor(x => x.Id, f => cliente.Id)
            .RuleFor(x => x.Nome, f => cliente.Nome)
            .RuleFor(x => x.CPF, f => cliente.CPF)
            .RuleFor(x => x.DataNascimento, f => cliente.DataNascimento);
        }
        public static ClienteDto CreateClienteDto()
        {
            return CreateClienteDtoFaker().Generate(); 
        }
        public static Cliente CreateCliente(ClienteDto tarefa)
        {
            return CreateClienteFaker(tarefa).Generate();
        }
        public static IEnumerable<Cliente> CreateIEnumerableCliente(ClienteDto cliente, int count)
        {
            return CreateClienteFaker(cliente).Generate(count);
        }
    }
}
