using ConsomeBrasilApi.Interfaces;
using ConsomeBrasilApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConsomeBrasilApi.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class CepController : Controller
    {
        public readonly ICep _cepService;

        public CepController(ICep cepService)
        {
            _cepService = cepService;
        }

        [HttpGet("Busca/Cep")]
        public async Task<IActionResult> BuscaCep(string cep)
        {
            var response = await _cepService.BuscaCep(cep);

            if (response.CodigoHttp == System.Net.HttpStatusCode.OK)
                return Ok(response.DadosRetorno);

            else
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }
}
