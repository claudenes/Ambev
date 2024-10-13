using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ambev.Domain.Entities;

namespace Ambev.Infra.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder) 
        {
            builder.ToTable("CLIENTE");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_CLIENTE")
                .HasColumnType("Int")
                .IsRequired();
            builder.Property(x => x.Nome)
                .HasColumnName("NOME_CLIENTE")
                .HasColumnType("VARCHAR")
                .HasMaxLength(5000)
                .IsRequired();
            builder.Property(x => x.CPF)
                .HasColumnName("CPF")
                .HasColumnType("VARCHAR")
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(x => x.DataNascimento)
                .HasColumnName("DATA_NASCIMENTO")
                .HasColumnType("DATETIME")
                .IsRequired();
            
        }
    }
}
