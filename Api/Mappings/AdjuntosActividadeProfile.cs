using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class AdjuntosActividadeProfile : Profile
{
    public AdjuntosActividadeProfile()
    {
        CreateMap<AdjuntosActividade, AdjuntosActividadeDto>().ReverseMap();
    }
}
