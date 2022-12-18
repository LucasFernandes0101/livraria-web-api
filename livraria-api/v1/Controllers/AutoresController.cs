using Livraria.Application.Interfaces;
using Livraria.Domain.Filters;
using Livraria.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace livraria_api.v1.Controllers
{
    [ApiController]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class AutoresController : ControllerBase
    {
        private readonly IAutorService _autorService;
        public AutoresController(IAutorService autorService)
        {
            _autorService = autorService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync([FromQuery] GetAutoresFilter request)
        {
            var response = new Helpers.HttpResponse();

            response.Content = await _autorService.GetAsync(request);
            response.Message = "Autores retornados com sucesso!";

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] AutorViewModel viewModel)
        {
            var response = new Helpers.HttpResponse();

            await _autorService.PostAsync(viewModel);
            response.Message = "Autor cadastrado com sucesso!";

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync([FromBody] AutorViewModel viewModel)
        {
            var response = new Helpers.HttpResponse();

            await _autorService.PutAsync(viewModel);
            response.Message = "Autor editado com sucesso!";

            return Ok(response);
        }
    }
}
