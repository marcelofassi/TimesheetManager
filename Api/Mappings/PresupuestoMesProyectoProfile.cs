using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class PresupuestoMesProyectoProfile : Profile
{
    public PresupuestoMesProyectoProfile()
    {
        CreateMap<PresupuestoMesProyecto, PresupuestoMesProyectoDto>().ReverseMap();
    }
}
