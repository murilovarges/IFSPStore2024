using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Endereco)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Bairro)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasOne(prop => prop.Cidade);

        }
    }
}