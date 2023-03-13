using ConsomeBrasilApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConsomeBrasilApi.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class SaudacaoController : Controller
    {
        private readonly SaudacaoService _saudacapService;

        public SaudacaoController(SaudacaoService saudacapService)
        {
            _saudacapService = saudacapService;
        }

        [HttpGet]
        public IActionResult Saudacao(string nome)
        {
            var mensagem = _saudacapService.Saudacao(nome);

            return Ok(mensagem);
        }
    }
}
