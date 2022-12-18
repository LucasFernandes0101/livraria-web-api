using Livraria.Domain.Base.Entities;

namespace Livraria.Domain.Exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException()
        {
        }

        public NotFoundException(string message)
            : base(message)
        {
        }
    }
}
