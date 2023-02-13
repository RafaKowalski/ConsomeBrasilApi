using AutoMapper;
using ConsomeBrasilApi.DTOs;
using ConsomeBrasilApi.Interfaces;
using ConsomeBrasilApi.Models;

namespace ConsomeBrasilApi.Services
{
    public class FeriadoService : IFeriado
    {
        private readonly IBrasilApi _brasilApi;
        private readonly IMapper _mapper;

        public FeriadoService(IBrasilApi brasilApi, IMapper mapper)
        {
            _brasilApi = brasilApi;
            _mapper = mapper;
        }

        public async Task<ResponseGenerico<List<Feriado>>> BuscaTodosFeriadosPorAno(string ano)
        {
            var feriados = await _brasilApi.BuscaTodosFeriadosPorAno(ano);

            return _mapper.Map<ResponseGenerico<List<Feriado>>>(feriados);
        }
    }
}
