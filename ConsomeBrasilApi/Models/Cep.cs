using System.Text.Json.Serialization;

namespace ConsomeBrasilApi.Models
{
    public class Cep
    {
        [JsonPropertyName("cep")]
        public string Endereco { get; set; }

        [JsonPropertyName("state")]
        public string? Estado { get; set; }

        [JsonPropertyName("city")]
        public string? Cidade { get; set; }

        [JsonPropertyName("neighborhood")]
        public string? Bairro { get; set; }

        [JsonPropertyName("street")]
        public string? Rua { get; set; }

        [JsonPropertyName("service")]
        public string? Servico { get; set; }
    }
}
