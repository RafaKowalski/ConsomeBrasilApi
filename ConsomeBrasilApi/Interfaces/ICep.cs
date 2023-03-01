using ConsomeBrasilApi.DTOs;
using ConsomeBrasilApi.Models;

namespace ConsomeBrasilApi.Interfaces
{
    public interface ICep
    {
        Task<ResponseGenerico<CepDto>> BuscaCep(string cep);
    }
}
