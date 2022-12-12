using Livraria.Domain.Filters;
using Livraria.Domain.ViewModels;

namespace Livraria.Application.Interfaces
{
    public interface IAutorService
    {
        Task PostAsync(AutorViewModel viewModel);
        Task PutAsync(AutorViewModel viewModel);
        Task<List<AutorViewModel>> GetAsync(GetAutoresFilter filter);
    }
}
