using System;

namespace Livraria.Infrastructure.Repositories.RabbitMQ
{
    public interface IRabbitMQIntegration : IDisposable
    {
        void PublishMessage(string message, string queue);
    }
}
