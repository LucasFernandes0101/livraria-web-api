namespace Livraria.Domain.Base.Entities
{
    public class BaseException : Exception
    {
        public BaseException()
        {
        }

        public BaseException(string message)
            : base(message)
        {
        }
    }
}
