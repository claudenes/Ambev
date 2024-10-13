using Microsoft.EntityFrameworkCore;
using Ambev.Domain.Entities;
using Ambev.Infra.Data.Mapping;

namespace Ambev.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Filial> Filial { get; set; }
        public DbSet<VendaProduto> VendaProdutos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Venda>(new VendaMap().Configure);
            modelBuilder.Entity<Produto>(new ProdutoMap().Configure);
            modelBuilder.Entity<Filial>(new FilialMap().Configure);
            modelBuilder.Entity<VendaProduto>(new VendaProdutoMap().Configure);
        }
    }
}
