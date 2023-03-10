using Microsoft.AspNetCore.Mvc;

namespace ConsomeBrasilApi.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class SaudacaoController : Controller
    {
        [HttpGet]
        public IActionResult Saudacao(string nome)
        {
            var mensagem = $"Ola {nome}, seja bem vindo ao projeto ConsomeBrasilApi \n" + DateTime.Now.ToString();

            return Ok(mensagem);
        }
    }
}
