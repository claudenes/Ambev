using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ambev.Domain.Entities;

namespace Ambev.Infra.Data.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder) 
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("Int")
                .IsRequired();
            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(5000)
                .IsRequired();
            builder.Property(x => x.Tipo)
                .HasColumnName("Tipo")
                .HasColumnType("VARCHAR")
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(x => x.Valor)
                .HasColumnName("Valor")
                .HasColumnType("DECIMAL")
                .IsRequired();

        }
    }
}
