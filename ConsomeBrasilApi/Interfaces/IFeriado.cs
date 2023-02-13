using ConsomeBrasilApi.DTOs;
using ConsomeBrasilApi.Models;

namespace ConsomeBrasilApi.Interfaces
{
    public interface IFeriado
    {
        Task<ResponseGenerico<List<Feriado>>> BuscaTodosFeriadosPorAno(string ano);
    }
}
