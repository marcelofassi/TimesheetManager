using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class HitoProfile : Profile
{
    public HitoProfile()
    {
        CreateMap<Hito, HitoDto>().ReverseMap();
    }
}
