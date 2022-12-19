using Livraria.Domain.Base.Entities;

namespace Livraria.Domain.Entities
{
    public class Promocao : BaseEntity
    {
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public Guid LivroId { get; set; }

        public virtual Livro? Livro { get; set; }
    }
}
