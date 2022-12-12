using Livraria.Domain.Base.Entities;

namespace Livraria.Domain.Filters
{
    public class GetLivrosFilter : BaseFilter
    {
        public string? Titulo { get; set; }
        public int? QtdPaginas { get; set; }
        public Guid? AutorId { get; set; }
    }
}