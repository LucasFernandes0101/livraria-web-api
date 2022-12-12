using Livraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infrastructure.Configurations
{
    public class AutorConfiguration : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("Autor");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)");

            builder.HasMany(x => x.Livros)
                .WithOne(x => x.Autor);

            builder.Property(x => x.DataCadastro).ValueGeneratedOnAdd();
            builder.Property(x => x.DataCadastro).ValueGeneratedOnUpdate();
        }
    }
}
