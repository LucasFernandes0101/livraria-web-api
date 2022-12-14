using Livraria.Domain.Entities;
using Livraria.Domain.Interfaces;
using Livraria.Infrastructure.Contexts;

namespace Livraria.Infrastructure.Repositories.SqlServer
{
    public class AutorRepository : BaseRepository<Autor>, IAutorRepository
    {
        public AutorRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
