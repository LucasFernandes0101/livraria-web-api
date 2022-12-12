using Livraria.Domain.Base.Entities;

namespace Livraria.Domain.Entities
{
    public class Livro : BaseEntity
    {
        public string Titulo { get; set; }
        public int QtdPaginas { get; set; }
        public virtual Autor Autor { get; set; }
    }
}
