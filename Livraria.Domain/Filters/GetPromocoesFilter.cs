using AspNetCore.IQueryable.Extensions.Attributes;
using AspNetCore.IQueryable.Extensions.Filter;
using Livraria.Domain.Base.Entities;

namespace Livraria.Domain.Filters
{
    public class GetPromocoesFilter : BaseFilter
    {
        [QueryOperator(Operator = WhereOperator.Contains)]
        public string? Titulo { get; set; }
        [QueryOperator(Operator = WhereOperator.Contains)]
        public string? Descricao { get; set; }
        public decimal? Preco { get; set; }
    }
}