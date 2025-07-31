using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class UbicacioneService : CrudService<Ubicacione, UbicacioneDto>
{
    public UbicacioneService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
