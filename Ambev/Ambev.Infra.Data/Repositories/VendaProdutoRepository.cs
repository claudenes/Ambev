using Ambev.Domain.Entities;
using Ambev.Domain.Interfaces;
using Ambev.Infra.Data.Context;

namespace Ambev.Infra.Data.Repositories
{
    public class VendaProdutoRepository : ResourceRepository<VendaProduto>, IVendaProdutoRepository
    {
        public VendaProdutoRepository(ApplicationDbContext context) : base(context) { }
    }
}
