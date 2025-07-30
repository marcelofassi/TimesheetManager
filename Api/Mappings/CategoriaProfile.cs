using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class CategoriaProfile : Profile
{
    public CategoriaProfile()
    {
        CreateMap<Categoria, CategoriaDto>().ReverseMap();
    }
}
