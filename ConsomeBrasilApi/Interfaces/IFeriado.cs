using ConsomeBrasilApi.DTOs;
using ConsomeBrasilApi.Models;

namespace ConsomeBrasilApi.Interfaces
{
    public interface IFeriado
    {
        Task<ResponseGenerico<List<FeriadoDto>>> BuscaTodosFeriadosPorAno(string ano);
    }
}
