using Livraria.Application.Interfaces;
using Livraria.Domain.Filters;
using Livraria.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace livraria_api.v1.Controllers
{
    [ApiController]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class PromocoesController : ControllerBase
    {
        private readonly IPromocaoService _promocaoService;
        public PromocoesController(IPromocaoService promocaoService)
        {
            _promocaoService = promocaoService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync([FromQuery] GetPromocoesFilter request)
        {
            var response = new Helpers.HttpResponse();

            response.Content = await _promocaoService.GetAsync(request);
            response.Message = "Promoções retornadas com sucesso!";

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] PromocaoViewModel viewModel)
        {
            var response = new Helpers.HttpResponse();

            await _promocaoService.PostAsync(viewModel);
            response.Message = "Promoção cadastrada com sucesso!";

            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync([FromBody] PromocaoViewModel viewModel)
        {
            var response = new Helpers.HttpResponse();

            await _promocaoService.PutAsync(viewModel);
            response.Message = "Promoção editada com sucesso!";

            return Ok(response);
        }
    }
}