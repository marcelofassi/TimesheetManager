using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class EstadosRecursosController : CrudController<EstadosRecurso, EstadosRecursoDto>
{
    public EstadosRecursosController(EstadosRecursoService service) : base(service) { }
}
