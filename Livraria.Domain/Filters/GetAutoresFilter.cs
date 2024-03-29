﻿using AspNetCore.IQueryable.Extensions.Attributes;
using AspNetCore.IQueryable.Extensions.Filter;
using Livraria.Domain.Base.Entities;

namespace Livraria.Domain.Filters
{
    public class GetAutoresFilter : BaseFilter
    {
        [QueryOperator(Operator = WhereOperator.Contains)]
        public string? Nome { get; set; }
    }
}
