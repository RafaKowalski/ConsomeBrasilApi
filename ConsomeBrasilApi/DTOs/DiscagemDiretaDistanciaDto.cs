using System.Text.Json.Serialization;

namespace ConsomeBrasilApi.DTOs
{
    public class DiscagemDiretaDistanciaDto
    {
        public string? Estado { get; set; }
        public List<string>? Cidades { get; set; }
    }
}
