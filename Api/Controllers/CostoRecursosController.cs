using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class CostoRecursosController : CrudController<CostoRecurso, CostoRecursoDto>
{
    public CostoRecursosController(CostoRecursoService service) : base(service) { }
}
