using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class RecursoProfile : Profile
{
    public RecursoProfile()
    {
        CreateMap<Recurso, RecursoDto>().ReverseMap();
    }
}
