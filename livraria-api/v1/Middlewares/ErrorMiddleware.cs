using Livraria.Domain.Base.Entities;
using Livraria.Domain.Exceptions;
using livraria_api.v1.Helpers;
using Newtonsoft.Json;

namespace livraria_api.v1.Middlewares
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate next;

        public ErrorMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            //TODO: Persistir LOG de erro, utilizando o ErrorId

            // Mensagem de erro utilizada em ambiente produtivo, caso a exceção não for customizada
            string errorMessage = ex is BaseException ? ex.Message : "Ocorreu um erro! :(";

            var errorResponseVm = new ErrorResponse();

            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development" ||
                Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Homologation"
                )
            {
                errorResponseVm = new ErrorResponse($"{ex.Message} {ex?.InnerException?.Message}");
            }
            else
            {
                errorResponseVm = new ErrorResponse(errorMessage);
            }

            var response = new Helpers.HttpResponse();
            response.Errors = errorResponseVm;
            response.Message = errorMessage;

            context.Response.StatusCode = (int)ExceptionStatusCodes.GetExceptionStatusCode(ex ?? new Exception());

            var result = JsonConvert.SerializeObject(response);
            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync(result);
        }
    }
}