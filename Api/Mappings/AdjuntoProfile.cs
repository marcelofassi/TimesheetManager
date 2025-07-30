using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class AdjuntoProfile : Profile
{
    public AdjuntoProfile()
    {
        CreateMap<Adjunto, AdjuntoDto>().ReverseMap();
    }
}
