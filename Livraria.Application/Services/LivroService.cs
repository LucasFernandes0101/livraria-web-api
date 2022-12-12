using Livraria.Application.Interfaces;
using Livraria.Domain.Entities;
using Livraria.Domain.Filters;
using Livraria.Domain.Interfaces;
using Livraria.Domain.ViewModels;

namespace Livraria.Application.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;
        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public async Task<LivroViewModel> GetAsync(GetLivrosFilter filter)
        {
            var pagedResult = await _livroRepository.GetAsync(filter);
        }

        public async Task PostAsync(Livro livro)
        {
            await _livroRepository.AddAsync(livro);
        }
    }
}
