// Application/Mappings/ProyectoProfile.cs
using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;
using System.Linq;

namespace TimesheetApi.Application.Mappings;

public class ProyectoProfile : Profile
{
    public ProyectoProfile()
    {
        CreateMap<Proyecto, ProyectoDto>()
            .ForMember(dest => dest.ResourceIds, opt => opt.MapFrom(src => src.ResourceToProjects.Select(rtp => rtp.ResourceId)))
            .ForMember(dest => dest.TecnologiaIds, opt => opt.MapFrom(src => src.ProyectosTecnologias.Select(pt => pt.IdTecnologia)))
            .ForMember(dest => dest.ResourceToProjects, opt => opt.MapFrom(src => src.ResourceToProjects))
            .ForMember(dest => dest.Tecnologias, opt => opt.MapFrom(src => src.ProyectosTecnologias.Select(pt => pt.IdTecnologiaNavigation)));

        CreateMap<ProyectoDto, Proyecto>()
            .ForMember(dest => dest.ResourceToProjects, opt => opt.Ignore())
            .ForMember(dest => dest.ProyectosTecnologias, opt => opt.Ignore());
    }
}
