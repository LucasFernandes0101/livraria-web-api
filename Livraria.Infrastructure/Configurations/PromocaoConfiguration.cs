using Livraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infrastructure.Configurations
{
    internal class PromocaoConfiguration : IEntityTypeConfiguration<Promocao>
    {
        public void Configure(EntityTypeBuilder<Promocao> builder)
        {
            builder.ToTable("Promocao");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Titulo)
                .HasColumnType("varchar(200)");

            builder.HasOne(x => x.Livro)
                .WithMany(x => x.Promocoes);
        }
    }
}
