using AutoMapper;
using ConsomeBrasilApi.DTOs;
using ConsomeBrasilApi.Interfaces;
using ConsomeBrasilApi.Models;

namespace ConsomeBrasilApi.Services
{
    public class DiscagemDiretaDistanciaService : IDiscagemDiretaDistancia
    {
        private readonly IBrasilApi _brasilApi;
        private readonly IMapper _mapper;

        public DiscagemDiretaDistanciaService(IBrasilApi brasilApi, IMapper mapper)
        {
            _brasilApi = brasilApi;
            _mapper = mapper;
        }

        public async Task<ResponseGenerico<DiscagemDiretaDistanciaDto>> BuscaDDDPorEstado(string ddd)
        {
            var discagemDiretaDistancia = await _brasilApi.BuscaDDDPorEstado(ddd);

            return _mapper.Map<ResponseGenerico<DiscagemDiretaDistanciaDto>>(ddd);
        }
    }
}
