using AutoMapper;
using Livraria.Domain.Entities;
using Livraria.Domain.ViewModels;

namespace Livraria.Domain.Mapper
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<Livro, LivroViewModel>()
                .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(x => x.Titulo, opt => opt.MapFrom(src => src.Titulo))
                .ForMember(x => x.AutorId, opt => opt.MapFrom(src => src.AutorId))
                .ForMember(x => x.QtdPaginas, opt => opt.MapFrom(src => src.QtdPaginas))
                .ForMember(x => x.DataCadastro, opt => opt.MapFrom(src => src.DataCadastro));

            CreateMap<LivroViewModel, Livro>()
                .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(x => x.Titulo, opt => opt.MapFrom(src => src.Titulo))
                .ForMember(x => x.AutorId, opt => opt.MapFrom(src => src.AutorId))
                .ForMember(x => x.QtdPaginas, opt => opt.MapFrom(src => src.QtdPaginas))
                .ForMember(x => x.DataCadastro, opt => opt.MapFrom(src => src.DataCadastro));
        }
    }
}
