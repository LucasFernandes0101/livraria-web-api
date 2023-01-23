using Livraria.Domain.Exceptions;
using Livraria.Infrastructure.Configurations;
using RabbitMQ.Client;
using System.Text;

namespace Livraria.Infrastructure.Repositories.RabbitMQ
{
    public class RabbitMQIntegration : IRabbitMQIntegration, IDisposable
    {
        private readonly IConnectionFactory _connectionFactory;
        private readonly IModel _channel;
        private readonly IConnection _connection;
        public RabbitMQIntegration()
        {
            _connectionFactory = new ConnectionFactory()
            {
                HostName = RabbitMQConfig.ConnectionString.HostName,
                UserName = RabbitMQConfig.ConnectionString.UserName,
                VirtualHost = RabbitMQConfig.ConnectionString.VirtualHost,
                Password = RabbitMQConfig.ConnectionString.Password
            };

            _connection = CreateConnection(_connectionFactory);
            _channel = _connection.CreateModel();
        }

        public void Dispose()
        {
            _channel.Close();
            _connection.Close();
        }

        public void PublishMessage(string message, string queue)
        {
            bool messagePublished = false;

            for (int attempts = 10; attempts > 0; attempts--)
            {
                try
                {
                    byte[] body = Encoding.Default.GetBytes(message);
                    _channel.QueueDeclare(queue: queue, durable: true, exclusive: false, autoDelete: false);
                    IBasicProperties basicProperties = _channel.CreateBasicProperties();
                    basicProperties.Persistent = true;
                    _channel.BasicPublish(exchange: String.Empty, routingKey: queue, basicProperties: basicProperties, body: body);
                    messagePublished = true;

                    attempts = 0;
                }
                catch (Exception)
                {
                }
            }

            if (!messagePublished)
                throw new RabbitMQPublishMessageException("[Erro] Não foi possível publicar a mensagem na fila do RabbitMQ.");
        }


        private IConnection CreateConnection(IConnectionFactory connectionFactory)
        {
            for (int i = 4; i > 0; i--)
            {
                try
                {
                    var connection = connectionFactory.CreateConnection();
                    return connection;
                }
                catch (Exception)
                {
                }
            }

            throw new RabbitMQCreateConnectionException("[Erro] Não foi possível criar conexão com a mensageria RabbitMQ.");
        }
    }
}
