using Livraria.Domain.Base.Entities;

namespace Livraria.Domain.Exceptions
{
    public class RabbitMQCreateConnectionException : BaseException
    {
        public RabbitMQCreateConnectionException()
        {
        }

        public RabbitMQCreateConnectionException(string message)
            : base(message)
        {
        }
    }
}
