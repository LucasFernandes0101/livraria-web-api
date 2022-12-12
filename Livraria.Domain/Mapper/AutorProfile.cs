using AutoMapper;
using Livraria.Domain.Entities;
using Livraria.Domain.ViewModels;

namespace Livraria.Domain.Mapper
{
    public class AutorProfile : Profile
    {
        public AutorProfile()
        {
            CreateMap<Autor, AutorViewModel>()
                .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(x => x.Nome, opt => opt.MapFrom(src => src.Nome));

            CreateMap<AutorViewModel, Autor>()
                .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(x => x.Nome, opt => opt.MapFrom(src => src.Nome));
        }
    }
}
