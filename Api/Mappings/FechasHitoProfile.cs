using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class FechasHitoProfile : Profile
{
    public FechasHitoProfile()
    {
        CreateMap<FechasHito, FechasHitoDto>().ReverseMap();
    }
}
