using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class EstadosRecursoProfile : Profile
{
    public EstadosRecursoProfile()
    {
        CreateMap<EstadosRecurso, EstadosRecursoDto>().ReverseMap();
    }
}
