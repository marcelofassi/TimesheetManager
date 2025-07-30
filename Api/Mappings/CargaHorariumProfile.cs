using AutoMapper;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Mappings;

public class CargaHorariumProfile : Profile
{
    public CargaHorariumProfile()
    {
        CreateMap<CargaHorarium, CargaHorariumDto>().ReverseMap();
    }
}
