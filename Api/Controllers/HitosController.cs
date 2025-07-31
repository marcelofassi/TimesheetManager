using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class HitosController : CrudController<Hito, HitoDto>
{
    public HitosController(HitoService service) : base(service) { }
}
