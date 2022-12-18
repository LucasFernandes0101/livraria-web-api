using System.Net;

namespace Livraria.Domain.Exceptions
{
    public static class ExceptionStatusCodes
    {
        private static Dictionary<Type, HttpStatusCode> exceptionsStatusCodes = new Dictionary<Type, HttpStatusCode>
        {
            {typeof(BadRequestException), HttpStatusCode.BadRequest},
            {typeof(NotFoundException), HttpStatusCode.NotFound}
        };

        public static HttpStatusCode GetExceptionStatusCode(Exception exception)
        {
            bool exceptionFound = exceptionsStatusCodes.TryGetValue(exception.GetType(), out HttpStatusCode statusCode);
            return exceptionFound ? statusCode : HttpStatusCode.InternalServerError;
        }
    }
}
