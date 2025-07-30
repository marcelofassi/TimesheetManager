using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class HojaDeTiempoProfile : Profile
{
    public HojaDeTiempoProfile()
    {
        CreateMap<HojaDeTiempo, HojaDeTiempoDto>().ReverseMap();
    }
}
