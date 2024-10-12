using Ambev.Domain.Entities;
using Ambev.Domain.Interfaces;
using Ambev.Infra.Data.Context;

namespace Ambev.Infra.Data.Repositories
{
    public class FilialRepository : ResourceRepository<Filial>, IFilialRepository
    {
        public FilialRepository(ApplicationDbContext context) : base(context) { }
    }
}
