using Livraria.Domain.Base.Entities;

namespace Livraria.Domain.Entities
{
    public class Autor : BaseEntity
    {
        public string? Nome { get; set; }

        public virtual IEnumerable<Livro>? Livros { get; set; }
    }
}
