// Application/Mappings/ProyectoProfile.cs
using AutoMapper;
using System.Linq;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class ProyectoProfile : Profile
{
    public ProyectoProfile()
    {
        CreateMap<Proyecto, ProyectoDto>()
            .ForMember(d => d.IdRecursos, opt => opt.MapFrom(s => s.ResourceToProjects.Select(r => r.ResourceId)))
            .ReverseMap()
            .ForMember(d => d.ResourceToProjects, opt => opt.Ignore());
    }
}
