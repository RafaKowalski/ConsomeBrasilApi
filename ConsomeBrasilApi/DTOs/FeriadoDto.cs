using System.Text.Json.Serialization;

namespace ConsomeBrasilApi.DTOs
{
    public class FeriadoDto
    {
        public string? Data { get; set; }

        public string? Nome { get; set; }

        public string? Tipo { get; set; }
    }
}
