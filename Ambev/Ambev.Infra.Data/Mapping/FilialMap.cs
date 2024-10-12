using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ambev.Domain.Entities;

namespace Ambev.Infra.Data.Mapping
{
    public class FilialMap : IEntityTypeConfiguration<Filial>
    {
        public void Configure(EntityTypeBuilder<Filial> builder) 
        {
            builder.ToTable("Filial");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("Int")
                .IsRequired();
            builder.Property(x => x.Nome)
                .HasColumnName("Filial")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            
        }
    }
}
