using AutoMapper;
using Livraria.Application.Interfaces;
using Livraria.Domain.Entities;
using Livraria.Domain.Filters;
using Livraria.Domain.Interfaces;
using Livraria.Domain.ViewModels;

namespace Livraria.Application.Services
{
    public class PromocaoService : IPromocaoService
    {
        private readonly IPromocaoRepository _promocaoRepository;
        private readonly IMapper _mapper;
        public PromocaoService(IPromocaoRepository promocaoRepository, IMapper mapper)
        {
            _promocaoRepository = promocaoRepository;
            _mapper = mapper;
        }

        public async Task<List<PromocaoViewModel>> GetAsync(GetPromocoesFilter filter)
        {
            var pagedResult = await _promocaoRepository.GetAsync(filter);

            return _mapper.Map<List<PromocaoViewModel>>(pagedResult.Items);
        }

        public async Task PostAsync(PromocaoViewModel viewModel)
        {
            var model = _mapper.Map<Promocao>(viewModel);

            await _promocaoRepository.AddAsync(model);

            var messageModel = _mapper.Map<PromocaoViewModel>(viewModel);
            await _promocaoRepository.PublishPromocaoInQueue(messageModel);
        }

        public async Task PutAsync(PromocaoViewModel viewModel)
        {
            var model = _mapper.Map<Promocao>(viewModel);

            await _promocaoRepository.UpdateAsync(model);
        }
    }
}