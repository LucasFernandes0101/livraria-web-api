using Livraria.Domain.Filters;
using Livraria.Domain.ViewModels;

namespace Livraria.Application.Interfaces
{
    public interface IPromocaoService
    {
        Task PostAsync(PromocaoViewModel viewModel);
        Task PutAsync(PromocaoViewModel viewModel);
        Task<List<PromocaoViewModel>> GetAsync(GetPromocaoFilter filter);
    }
}
