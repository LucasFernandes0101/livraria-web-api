using Livraria.Domain.Base.Interfaces;
using Livraria.Domain.Entities;

namespace Livraria.Domain.Interfaces
{
    public interface IAutorRepository : IBaseRepository<Autor>
    {
        Task<Autor?> GetByIdWithBooks(Guid id);
    }
}
