using Ambev.Domain.Entities;
using Ambev.Domain.Interfaces;
using Ambev.Infra.Data.Context;

namespace Ambev.Infra.Data.Repositories
{
    public class ProdutoRepository : ResourceRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext context) : base(context) { }
    }
}
