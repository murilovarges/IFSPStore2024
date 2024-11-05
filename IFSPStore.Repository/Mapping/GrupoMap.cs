
using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class GrupoMap : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            // Define o nome da tabela
            builder.ToTable("Abobrinha");
            // Define a chave primária
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasColumnName("melancia")
                .IsRequired()
                .HasMaxLength(50);
                //.HasColumnType("varchar(50)");
        }
    }
}
