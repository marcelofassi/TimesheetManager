using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class TecnologiaProfile : Profile
{
    public TecnologiaProfile()
    {
        CreateMap<Tecnologia, TecnologiaDto>().ReverseMap();
    }
}
