using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class UbicacionOficinasDiveriumProfile : Profile
{
    public UbicacionOficinasDiveriumProfile()
    {
        CreateMap<UbicacionOficinasDiverium, UbicacionOficinasDiveriumDto>().ReverseMap();
    }
}
