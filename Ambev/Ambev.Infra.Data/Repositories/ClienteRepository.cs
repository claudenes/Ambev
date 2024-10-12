using Ambev.Domain.Entities;
using Ambev.Domain.Interfaces;
using Ambev.Infra.Data.Context;

namespace Ambev.Infra.Data.Repositories
{
    public class ClienteRepository : ResourceRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationDbContext context) : base(context) { }
    }
}
