using AutoMapper;
using Livraria.Application.Interfaces;
using Livraria.Application.Services;
using Livraria.Domain.Base.Interfaces;
using Livraria.Domain.Interfaces;
using Livraria.Domain.Mapper;
using Livraria.Infrastructure.Contexts;
using Livraria.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.Application
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDependencies(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddAutoMapperProfiles();
            service.AddRepositories(configuration);
            service.AddServices();

            return service;
        }

        private static void AddRepositories(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<SqlDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("LivrariaDB")));

            service.AddScoped<ILivroRepository, LivroRepository>();
            service.AddScoped<IAutorRepository, AutorRepository>();
        }

        private static void AddServices(this IServiceCollection service)
        {
            service.AddScoped<ILivroService, LivroService>();
            service.AddScoped<IAutorService, AutorService>();
        }

        private static void AddAutoMapperProfiles(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(LivroProfile));
            service.AddAutoMapper(typeof(AutorProfile));
        }
    }
}
