using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class FeriadosController : CrudController<Feriado, FeriadoDto>
{
    public FeriadosController(FeriadoService service) : base(service) { }
}
