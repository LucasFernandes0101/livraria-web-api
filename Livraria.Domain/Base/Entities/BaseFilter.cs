using AspNetCore.IQueryable.Extensions;

namespace Livraria.Domain.Base.Entities
{
    public class BaseFilter : ICustomQueryable
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Active { get; set; }
        public int Page { get; set; } = 1;
        public int MaxResults { get; set; } = 10;
    }
}
