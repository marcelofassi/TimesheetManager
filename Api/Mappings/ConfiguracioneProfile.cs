using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class ConfiguracioneProfile : Profile
{
    public ConfiguracioneProfile()
    {
        CreateMap<Configuracione, ConfiguracioneDto>().ReverseMap();
    }
}
