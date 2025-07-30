using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class PaiProfile : Profile
{
    public PaiProfile()
    {
        CreateMap<Pai, PaiDto>().ReverseMap();
    }
}
