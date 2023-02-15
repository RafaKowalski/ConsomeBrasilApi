using AutoMapper;
using ConsomeBrasilApi.DTOs;
using ConsomeBrasilApi.Models;

namespace ConsomeBrasilApi.Mapping
{
    public class DiscagemDiretaDistanciaMapping : Profile
    {
        public DiscagemDiretaDistanciaMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<DiscagemDiretaDistancia, DiscagemDiretaDistanciaDto>();
            CreateMap<DiscagemDiretaDistanciaDto, DiscagemDiretaDistancia>();
        }
    }
}
