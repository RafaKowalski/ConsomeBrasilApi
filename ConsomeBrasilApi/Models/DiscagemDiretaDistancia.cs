using System.Text.Json.Serialization;

namespace ConsomeBrasilApi.Models
{
    public class DiscagemDiretaDistancia
    {
        [JsonPropertyName("state")]
        public string? Estado { get; set; }

        [JsonPropertyName("cities")]
        public List<string>? Cidades { get; set; }
    }
}
