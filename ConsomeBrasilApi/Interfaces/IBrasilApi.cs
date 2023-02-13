using ConsomeBrasilApi.DTOs;
using ConsomeBrasilApi.Models;

namespace ConsomeBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<List<Feriado>>> BuscaTodosFeriadosPorAno(string ano);
    }
}
