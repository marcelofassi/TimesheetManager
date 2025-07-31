using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class RecursoTecnologiumsController : CrudController<RecursoTecnologium, RecursoTecnologiumDto>
{
    public RecursoTecnologiumsController(RecursoTecnologiumService service) : base(service) { }
}
