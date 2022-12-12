using Livraria.Application.Interfaces;
using Livraria.Domain.Filters;
using Livraria.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace livraria_api.v1.Controllers
{
    [ApiController]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroService _livroService;
        public LivrosController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        public async Task<ActionResult<LivroViewModel>> GetAsync([FromQuery] GetLivrosFilter request, int page = 1, int maxResults = 10)
        {
            var response = new Helpers.HttpResponse() { Success = true };

            try
            {
                response.Content = await _livroService.GetAsync(request, page, maxResults);
                response.Message = "Livros retornados com sucesso!";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro ao obter livros!";
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}