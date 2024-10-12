using Ambev.Domain.Entities;
using Ambev.Domain.Interfaces;
using Ambev.Infra.Data.Context;

namespace Ambev.Infra.Data.Repositories
{
    public class VendaRepository : ResourceRepository<Venda>, IVendaRepository
    {
        public VendaRepository(ApplicationDbContext context) : base(context) { }
    }
}
