using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class ActividadeProfile : Profile
{
    public ActividadeProfile()
    {
        CreateMap<Actividade, ActividadeDto>().ReverseMap();
    }
}
