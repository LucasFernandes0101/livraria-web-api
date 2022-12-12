using Livraria.Domain.Base.Interfaces;
using Livraria.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Livraria.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        protected SqlDbContext _dbContext { get; set; }

        public BaseRepository(SqlDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IPagedResult<T>> GetAsync(Expression<Func<T, bool>> criteria, int page, int maxResults = 10)
        {
            throw new NotImplementedException();
        }

        public async Task<IPagedResult<T>> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(T entity)
        {
            entity.DataCadastro = DateTime.Now;
            entity.DataAlteracao = DateTime.Now;

            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            entity.Active = false;

            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            entity.DataAlteracao = DateTime.Now;

            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
