using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ambev.Domain.Entities;

namespace Ambev.Infra.Data.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder) 
        {
            builder.ToTable("PRODUTO");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_PRODUTO")
                .HasColumnType("Int")
                .IsRequired();
            builder.Property(x => x.Nome)
                .HasColumnName("NOME_PRODUTO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(5000)
                .IsRequired();
            builder.Property(x => x.Tipo)
                .HasColumnName("TIPO_PRODUTO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(x => x.Valor)
                .HasColumnName("VALOR")
                .HasColumnType("DECIMAL")
                .IsRequired();

        }
    }
}
