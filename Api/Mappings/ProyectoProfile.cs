// Application/Mappings/ProyectoProfile.cs
using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class ProyectoProfile : Profile
{
    public ProyectoProfile()
    {
        CreateMap<Proyecto, ProyectoDto>().ReverseMap();
    }
}
