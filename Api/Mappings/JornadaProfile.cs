using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class JornadaProfile : Profile
{
    public JornadaProfile()
    {
        CreateMap<Jornada, JornadaDto>().ReverseMap();
    }
}
