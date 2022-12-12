using Livraria.Domain.Entities;
using Livraria.Domain.Filters;
using Livraria.Domain.ViewModels;

namespace Livraria.Application.Interfaces
{
    public interface ILivroService
    {
        Task PostAsync(Livro livro);
        Task<LivroViewModel> GetAsync(GetLivrosFilter filter);
    }
}
