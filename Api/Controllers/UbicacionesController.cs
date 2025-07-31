using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class UbicacionesController : CrudController<Ubicacione, UbicacioneDto>
{
    public UbicacionesController(UbicacioneService service) : base(service) { }
}
