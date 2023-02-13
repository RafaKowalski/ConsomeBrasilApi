using ConsomeBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConsomeBrasilApi.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class FeriadoController : Controller
    {
        public readonly IFeriado _feriadoService;

        public FeriadoController(IFeriado feriadoService)
        {
            _feriadoService = feriadoService;
        }

        [HttpGet("Busca/Feriados")]
        public async Task<IActionResult> BuscaTodosFeriadosPorAno(string ano)
        {
            var response = await _feriadoService.BuscaTodosFeriadosPorAno(ano);

            if (response.CodigoHttp == System.Net.HttpStatusCode.OK)
                return Ok(response.DadosRetorno);

            else
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
    }
}
