using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class FechasHitosController : CrudController<FechasHito, FechasHitoDto>
{
    public FechasHitosController(FechasHitoService service) : base(service) { }
}
