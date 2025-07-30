using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class FeriadoProfile : Profile
{
    public FeriadoProfile()
    {
        CreateMap<Feriado, FeriadoDto>().ReverseMap();
    }
}
