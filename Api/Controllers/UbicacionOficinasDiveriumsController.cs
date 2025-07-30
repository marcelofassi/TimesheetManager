using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class UbicacionOficinasDiveriumsController : CrudController<UbicacionOficinasDiverium, UbicacionOficinasDiveriumDto>
{
    public UbicacionOficinasDiveriumsController(UbicacionOficinasDiveriumService service) : base(service) { }
}
