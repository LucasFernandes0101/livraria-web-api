using AutoMapper;
using Livraria.Application.Interfaces;
using Livraria.Domain.Entities;
using Livraria.Domain.Filters;
using Livraria.Domain.Interfaces;
using Livraria.Domain.ViewModels;

namespace Livraria.Application.Services
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _autorRepository;
        private readonly IMapper _mapper;
        public AutorService(IAutorRepository autorRepository, IMapper mapper)
        {
            _autorRepository = autorRepository;
            _mapper = mapper;
        }

        public async Task<Autor?> GetByIdWithBooks(Guid id)
        {
            var autor = await _autorRepository.GetByIdWithBooks(id);

            return autor;
        }

        public async Task<List<AutorViewModel>> GetAsync(GetAutoresFilter filter)
        {
            var pagedResult = await _autorRepository.GetAsync(filter);

            return _mapper.Map<List<AutorViewModel>>(pagedResult.Items);
        }

        public async Task PostAsync(AutorViewModel viewModel)
        {
            var model = _mapper.Map<Autor>(viewModel);

            await _autorRepository.AddAsync(model);
        }

        public async Task PutAsync(AutorViewModel viewModel)
        {
            var model = _mapper.Map<Autor>(viewModel);

            await _autorRepository.UpdateAsync(model);
        }
    }
}
