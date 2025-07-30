using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class EstadosDeActividadeProfile : Profile
{
    public EstadosDeActividadeProfile()
    {
        CreateMap<EstadosDeActividade, EstadosDeActividadeDto>().ReverseMap();
    }
}
