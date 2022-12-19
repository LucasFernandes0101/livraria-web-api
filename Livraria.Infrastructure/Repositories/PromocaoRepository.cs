using Livraria.Domain.Entities;
using Livraria.Domain.Interfaces;
using Livraria.Infrastructure.Contexts;

namespace Livraria.Infrastructure.Repositories
{
    public class PromocaoRepository : BaseRepository<Promocao>, IPromocaoRepository
    {
        public PromocaoRepository(SqlDbContext context) : base(context)
        {
        }
    }
}
