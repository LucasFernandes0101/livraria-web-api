using Livraria.Domain.Entities;
using Livraria.Domain.Interfaces;
using Livraria.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Infrastructure.Repositories.SqlServer
{
    public class AutorRepository : BaseRepository<Autor>, IAutorRepository
    {
        protected new SqlDbContext _dbContext { get; set; }

        public AutorRepository(SqlDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task<Autor?> GetByIdWithBooks(Guid id)
        {
            IQueryable<Autor> query = _dbContext.Set<Autor>().AsQueryable().Where(x => x.Id.Equals(id)).Include(x => x.Livros);

            return await query.FirstOrDefaultAsync();
        }
    }
}
