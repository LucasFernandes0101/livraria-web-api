using Livraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Livraria.Infrastructure.Configurations.Builders
{
    public class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Titulo)
                .HasColumnType("varchar(100)");
            builder.Property(x => x.QtdPaginas)
                .HasColumnType("smallint");
            builder.Property(x => x.Preco)
                .HasColumnType("decimal(10,2)");

            builder.HasOne(x => x.Autor)
                .WithMany(x => x.Livros);

            builder.Property(x => x.DataCadastro).ValueGeneratedOnAdd();
            builder.Property(x => x.DataCadastro).ValueGeneratedOnUpdate();
        }
    }
}
