using Livraria.Domain.Entities;
using Livraria.Domain.Interfaces;
using Livraria.Infrastructure.Contexts;

namespace Livraria.Infrastructure.Repositories.SqlServer
{
    public class LivroRepository : BaseRepository<Livro>, ILivroRepository
    {
        public LivroRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
