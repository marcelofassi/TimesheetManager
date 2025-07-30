using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class PresupuestoMesProyectosController : CrudController<PresupuestoMesProyecto, PresupuestoMesProyectoDto>
{
    public PresupuestoMesProyectosController(PresupuestoMesProyectoService service) : base(service) { }
}
