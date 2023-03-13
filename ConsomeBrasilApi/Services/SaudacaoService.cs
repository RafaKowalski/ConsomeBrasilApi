namespace ConsomeBrasilApi.Services
{
    public class SaudacaoService
    {
        public string Saudacao(string nome)
        {
            return $"Ola {nome}, seja bem vindo ao projeto ConsomeBrasilApi \n" + DateTime.Now.ToString();
        }
    }
}
