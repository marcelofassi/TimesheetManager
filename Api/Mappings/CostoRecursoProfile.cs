using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class CostoRecursoProfile : Profile
{
    public CostoRecursoProfile()
    {
        CreateMap<CostoRecurso, CostoRecursoDto>().ReverseMap();
    }
}
