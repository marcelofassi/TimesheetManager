using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class ProyectosTecnologiaProfile : Profile
{
    public ProyectosTecnologiaProfile()
    {
        CreateMap<ProyectosTecnologia, ProyectosTecnologiaDto>().ReverseMap();
    }
}
