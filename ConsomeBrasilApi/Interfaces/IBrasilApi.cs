using ConsomeBrasilApi.Models;

namespace ConsomeBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<Feriado>> BuscaTodosFeriadosPorAno(string ano);
    }
}
