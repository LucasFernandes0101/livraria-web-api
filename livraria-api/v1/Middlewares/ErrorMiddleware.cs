using livraria_api.v1.Helpers;
using Newtonsoft.Json;
using System.Net;

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
            //Persistir LOG de erro, utilizando o TraceId

            ErrorResponse errorResponseVm;

            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development" ||
                Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Homologation"
                )
            {
                errorResponseVm = new ErrorResponse(HttpStatusCode.InternalServerError.ToString(),
                                                      $"{ex.Message} {ex?.InnerException?.Message}");
            }
            else
            {
                errorResponseVm = new ErrorResponse(HttpStatusCode.InternalServerError.ToString(),
                                                      "Esse é um erro padronizado para produção.");
            }

            var response = new Helpers.HttpResponse();
            response.Errors = errorResponseVm;

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var result = JsonConvert.SerializeObject(response);
            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync(result);
        }
    }
}