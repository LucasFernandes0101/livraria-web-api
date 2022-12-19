using AutoMapper;
using Livraria.Domain.Entities;
using Livraria.Domain.ViewModels;

namespace Livraria.Domain.Mapper
{
    public class PromocaoProfile : Profile
    {
        public PromocaoProfile()
        {
            CreateMap<Promocao, PromocaoViewModel>()
                .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(x => x.Titulo, opt => opt.MapFrom(src => src.Titulo))
                .ForMember(x => x.Descricao, opt => opt.MapFrom(src => src.Descricao))
                .ForMember(x => x.LivroId, opt => opt.MapFrom(src => src.LivroId));

            CreateMap<PromocaoViewModel, Promocao>()
                .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(x => x.Titulo, opt => opt.MapFrom(src => src.Titulo))
                .ForMember(x => x.Descricao, opt => opt.MapFrom(src => src.Descricao))
                .ForMember(x => x.LivroId, opt => opt.MapFrom(src => src.LivroId));
        }
    }  
}
