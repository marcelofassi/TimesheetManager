using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class RecursosController : CrudController<Recurso, RecursoDto>
{
    public RecursosController(RecursoService service) : base(service) { }
}
