using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class RecursoCategoriumProfile : Profile
{
    public RecursoCategoriumProfile()
    {
        CreateMap<RecursoCategorium, RecursoCategoriumDto>().ReverseMap();
    }
}
