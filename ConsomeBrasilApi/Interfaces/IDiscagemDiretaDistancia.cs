using ConsomeBrasilApi.DTOs;
using ConsomeBrasilApi.Models;

namespace ConsomeBrasilApi.Interfaces
{
    public interface IDiscagemDiretaDistancia
    {
        Task<ResponseGenerico<DiscagemDiretaDistanciaDto>> BuscaDDDPorEstado(string ddd);
    }
}
