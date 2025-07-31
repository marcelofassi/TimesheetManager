using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class CargaHorariumService : CrudService<CargaHorarium, CargaHorariumDto>
{
    public CargaHorariumService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
