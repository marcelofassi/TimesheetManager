using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class ResourceToActivityProfile : Profile
{
    public ResourceToActivityProfile()
    {
        CreateMap<ResourceToActivity, ResourceToActivityDto>().ReverseMap();
    }
}
