using Livraria.Domain.Base.Interfaces;
using Livraria.Domain.Entities;
using Livraria.Domain.ViewModels;

namespace Livraria.Domain.Interfaces
{
    public interface IPromocaoRepository : IBaseRepository<Promocao>
    {
        public Task PublishPromocaoInQueue(PromocaoViewModel promocao);
    }
}
