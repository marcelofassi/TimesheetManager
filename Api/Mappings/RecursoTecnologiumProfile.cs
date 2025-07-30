using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class RecursoTecnologiumProfile : Profile
{
    public RecursoTecnologiumProfile()
    {
        CreateMap<RecursoTecnologium, RecursoTecnologiumDto>().ReverseMap();
    }
}
