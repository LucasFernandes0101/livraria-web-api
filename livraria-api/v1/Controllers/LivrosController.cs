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
            var response = new Helpers.HttpResponse() { Success = true };

            try
            {
                response.Content = await _livroService.GetAsync(request);
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

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] LivroViewModel viewModel)
        {
            var response = new Helpers.HttpResponse() { Success = true };

            try
            {
                await _livroService.PostAsync(viewModel);
                response.Message = "Livro cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro ao cadastrar livro!";
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync([FromBody] LivroViewModel viewModel)
        {
            var response = new Helpers.HttpResponse() { Success = true };

            try
            {
                await _livroService.PutAsync(viewModel);
                response.Message = "Livro atualizado com sucesso!";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro ao atualizar livro!";
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}