using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ambev.Domain.Entities;

namespace Ambev.Infra.Data.Mapping
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder) 
        {
            builder.ToTable("VENDA");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Cliente);
            builder.HasOne(x => x.Filial);
            //builder.HasMany(x => x.VendaProduto);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_VENDA")
                .HasColumnType("Int")
                .IsRequired();
            builder.Property(x => x.ClienteId)
                .HasColumnName("ID_CLIENTE")
                .HasColumnType("Int")
                .IsRequired();
            builder.Property(x => x.FilialId)
                .HasColumnName("ID_FILIAL")
                .HasColumnType("Int")
                .IsRequired();
            builder.Property(x => x.ValorTotalVenda)
                .HasColumnName("VALOR_TOTAL")
                .HasColumnType("DECIMAL")
                .IsRequired();
            builder.Property(x => x.DataVenda)
                .HasColumnName("DATA_VENDA")
                .HasColumnType("DATETIME")
                .IsRequired();
            builder.Property(x => x.Cancelado)
                .HasColumnName("CANCELADO")
                .HasColumnType("BIT")
                .IsRequired();

        }
    }
}
