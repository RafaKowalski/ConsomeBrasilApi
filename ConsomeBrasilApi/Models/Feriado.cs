using System.Text.Json.Serialization;

namespace ConsomeBrasilApi.Models
{
    public class Feriado
    {
        [JsonPropertyName("date")]
        public string? Data { get; set; }

        [JsonPropertyName("name")]
        public string? Nome { get; set; }

        [JsonPropertyName("type")]
        public string? Tipo { get; set; }
    }
}
