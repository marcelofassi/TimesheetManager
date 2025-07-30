using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class PresupuestoMesProyectoService : CrudService<PresupuestoMesProyecto, PresupuestoMesProyectoDto>
{
    public PresupuestoMesProyectoService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
