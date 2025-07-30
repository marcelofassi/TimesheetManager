using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class CierreMeProfile : Profile
{
    public CierreMeProfile()
    {
        CreateMap<CierreMe, CierreMeDto>().ReverseMap();
    }
}
