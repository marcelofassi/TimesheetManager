using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class ResourceToProjectProfile : Profile
{
    public ResourceToProjectProfile()
    {
        CreateMap<ResourceToProject, ResourceToProjectDto>().ReverseMap();
    }
}
