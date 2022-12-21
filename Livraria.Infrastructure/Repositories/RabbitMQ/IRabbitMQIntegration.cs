namespace Livraria.Infrastructure.Repositories.RabbitMQ
{
    public interface IRabbitMQIntegration
    {
        void PublishMessage(string message, string queue);
    }
}
