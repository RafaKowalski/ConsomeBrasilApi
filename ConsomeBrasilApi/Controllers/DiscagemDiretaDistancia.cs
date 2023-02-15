using ConsomeBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConsomeBrasilApi.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class DiscagemDiretaDistancia : Controller
    {

        public readonly IDiscagemDiretaDistancia _discagemDiretaDistancia;

        public DiscagemDiretaDistancia(IDiscagemDiretaDistancia discagemDiretaDistancia)
        {
            _discagemDiretaDistancia = discagemDiretaDistancia;
        }

        [HttpGet("Busca/DDD")]
        public async Task<IActionResult> BuscaDDDPorEstado(string ddd)
        {
            var response = await _discagemDiretaDistancia.BuscaDDDPorEstado(ddd);

            if (response.CodigoHttp == System.Net.HttpStatusCode.OK)
                return Ok(response.DadosRetorno);

            else
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }
}
