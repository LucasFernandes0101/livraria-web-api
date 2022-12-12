using Livraria.Domain.Base.Entities;
using Livraria.Domain.Filters;
using Livraria.Domain.ViewModels;

namespace Livraria.Application.Interfaces
{
    public interface ILivroService
    {
        Task PostAsync(LivroViewModel viewModel);
        Task PutAsync(LivroViewModel viewModel);
        Task<List<LivroViewModel>> GetAsync(GetLivrosFilter filter);
    }
}
