using Livraria.Domain.Base.Entities;

namespace Livraria.Domain.Entities
{
    public class Livro : BaseEntity
    {
        public Guid AutorId { get; set; }
        public string? Titulo { get; set; }
        public int QtdPaginas { get; set; }
        public decimal Preco { get; set; }

        public virtual Autor? Autor { get; set; }
        public virtual IEnumerable<Promocao>? Promocoes { get; set; }
    }
}
