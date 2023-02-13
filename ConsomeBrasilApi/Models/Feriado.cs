using System.Text.Json.Serialization;

namespace ConsomeBrasilApi.Models
{
    public class Feriado
    {
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }
}
