using Livraria.Domain.Base.Entities;

namespace Livraria.Domain.Exceptions
{
    public class BadRequestException : BaseException
    {
        public BadRequestException()
        {
        }

        public BadRequestException(string message)
            : base(message)
        {
        }
    }
}
