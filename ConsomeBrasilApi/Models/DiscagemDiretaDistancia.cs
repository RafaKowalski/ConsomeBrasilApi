using System.Text.Json.Serialization;

namespace ConsomeBrasilApi.Models
{
    public class DiscagemDiretaDistancia
    {
        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("cities")]
        public List<string>? Cities { get; set; }
    }
}
