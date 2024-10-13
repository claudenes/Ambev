using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ambev.Domain.Entities;

namespace Ambev.Infra.Data.Mapping
{
    public class VendaProdutoMap : IEntityTypeConfiguration<VendaProduto>
    {
        public void Configure(EntityTypeBuilder<VendaProduto> builder) 
        {
            builder.ToTable("VENDA_PRODUTO");
            builder.HasKey(x => x.VendaId);
        
            builder.Property(x => x.VendaId)
                .HasColumnName("ID_VENDA")
                .HasColumnType("Int")
                .IsRequired();
            builder.Property(x => x.ProdutoId)
                .HasColumnName("ID_PRODUTO")
                .HasColumnType("Int")
                .IsRequired();

        }
    }
}
