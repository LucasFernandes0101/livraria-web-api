using AutoMapper;
using Livraria.Application.Interfaces;
using Livraria.Domain.Base.Entities;
using Livraria.Domain.Entities;
using Livraria.Domain.Filters;
using Livraria.Domain.Interfaces;
using Livraria.Domain.ViewModels;

namespace Livraria.Application.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;
        private readonly IMapper _mapper;
        public LivroService(ILivroRepository livroRepository, IMapper mapper)
        {
            _livroRepository = livroRepository;
            _mapper = mapper;
        }

        public async Task<List<LivroViewModel>> GetAsync(GetLivrosFilter filter)
        {
            var pagedResult = await _livroRepository.GetAsync(filter);

            return _mapper.Map<List<LivroViewModel>>(pagedResult.Items);
        }

        public async Task PostAsync(LivroViewModel viewModel)
        {
            var model = _mapper.Map<Livro>(viewModel);

            await _livroRepository.AddAsync(model);
        }

        public async Task PutAsync(LivroViewModel viewModel)
        {
            var model = _mapper.Map<Livro>(viewModel);

            await _livroRepository.UpdateAsync(model);
        }
    }
}
