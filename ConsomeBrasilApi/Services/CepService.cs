using AutoMapper;
using ConsomeBrasilApi.DTOs;
using ConsomeBrasilApi.Interfaces;

namespace ConsomeBrasilApi.Services
{
    public class CepService : ICep
    {
        private readonly IBrasilApi _brasilApi;
        private readonly IMapper _mapper;

        public CepService(IBrasilApi brasilApi, IMapper mapper)
        {
            _brasilApi = brasilApi;
            _mapper = mapper;
        }

        public async Task<ResponseGenerico<CepDto>> BuscaCep(string cep)
        {
            var enderecoCep = await _brasilApi.BuscaCep(cep);

            return _mapper.Map<ResponseGenerico<CepDto>>(enderecoCep);
        }
    }
}
