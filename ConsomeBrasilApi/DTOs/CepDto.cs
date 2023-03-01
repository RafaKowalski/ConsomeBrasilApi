using System.Text.Json.Serialization;

namespace ConsomeBrasilApi.DTOs
{
    public class CepDto
    {
        public string Endereco { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? Rua { get; set; }
        public string? Servico { get; set; }
    }
}
