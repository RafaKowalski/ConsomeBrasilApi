using AutoMapper;
using ConsomeBrasilApi.DTOs;
using ConsomeBrasilApi.Models;

namespace ConsomeBrasilApi.Mapping
{
    public class FeriadoMapping : Profile
    {
        public FeriadoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<Feriado, FeriadoDto>();
            CreateMap<FeriadoDto, Feriado>();
        }
    }
}
