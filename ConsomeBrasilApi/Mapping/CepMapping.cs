using AutoMapper;
using ConsomeBrasilApi.DTOs;
using ConsomeBrasilApi.Models;

namespace ConsomeBrasilApi.Mapping
{
    public class CepMapping : Profile
    {
        public CepMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<Cep, CepDto>().ReverseMap();
        }
    }
}
