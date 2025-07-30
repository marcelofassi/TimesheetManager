using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class ActividadesEstadoProfile : Profile
{
    public ActividadesEstadoProfile()
    {
        CreateMap<ActividadesEstado, ActividadesEstadoDto>().ReverseMap();
    }
}
