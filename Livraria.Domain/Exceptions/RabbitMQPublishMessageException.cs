using Livraria.Domain.Base.Entities;

namespace Livraria.Domain.Exceptions
{
    public class RabbitMQPublishMessageException : BaseException
    {
        public RabbitMQPublishMessageException()
        {
        }

        public RabbitMQPublishMessageException(string message)
            : base(message)
        {
        }
    }
}
