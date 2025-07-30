using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class UbicacioneProfile : Profile
{
    public UbicacioneProfile()
    {
        CreateMap<Ubicacione, UbicacioneDto>().ReverseMap();
    }
}
