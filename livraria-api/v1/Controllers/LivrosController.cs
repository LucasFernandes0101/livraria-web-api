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

        [HttpGet]
        public async Task<ActionResult> GetAsync([FromQuery] GetLivrosFilter request)
        {
            var response = new Helpers.HttpResponse();

            response.Content = await _livroService.GetAsync(request);
            response.Message = "Livros retornados com sucesso!";

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] LivroViewModel viewModel)
        {
            var response = new Helpers.HttpResponse();

            await _livroService.PostAsync(viewModel);
            response.Message = "Livro cadastrado com sucesso!";

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync([FromBody] LivroViewModel viewModel)
        {
            var response = new Helpers.HttpResponse();

            await _livroService.PutAsync(viewModel);
            response.Message = "Livro editado com sucesso!";

            return Ok(response);
        }
    }
}