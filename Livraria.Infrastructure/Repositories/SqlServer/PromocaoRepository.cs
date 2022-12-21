using Livraria.Domain.Entities;
using Livraria.Domain.Interfaces;
using Livraria.Domain.ViewModels;
using Livraria.Infrastructure.Configurations;
using Livraria.Infrastructure.Contexts;
using Livraria.Infrastructure.Repositories.RabbitMQ;
using System.Text.Json;

namespace Livraria.Infrastructure.Repositories.SqlServer
{
    public class PromocaoRepository : BaseRepository<Promocao>, IPromocaoRepository
    {
        private readonly IRabbitMQIntegration _rabbitMQIntegration;
        public PromocaoRepository(SqlDbContext context, IRabbitMQIntegration rabbitMQIntegration) : base(context)
        {
            _rabbitMQIntegration = rabbitMQIntegration;
        }

        public async Task PublishPromocaoInQueue(PromocaoViewModel promocao)
        {
            var message = JsonSerializer.Serialize(promocao);
            _rabbitMQIntegration.PublishMessage(message, RabbitMQConfig.Queues.Promocoes);
        }
    }
}
