using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class HojaDeTiemposController : CrudController<HojaDeTiempo, HojaDeTiempoDto>
{
    public HojaDeTiemposController(HojaDeTiempoService service) : base(service) { }
}
