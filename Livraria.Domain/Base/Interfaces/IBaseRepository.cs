﻿using AspNetCore.IQueryable.Extensions;
using Livraria.Domain.Base.Entities;
using System.Linq.Expressions;

namespace Livraria.Domain.Base.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<IPagedResult<T>> GetAsync(BaseFilter filter);
        Task<IPagedResult<T>> GetAsync(Expression<Func<T, bool>> criteria, int page = 1, int maxResults = 10);
        Task<T?> GetByIdAsync(Guid Id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
