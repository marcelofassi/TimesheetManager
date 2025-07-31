using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class RecursoCategoriumsController : CrudController<RecursoCategorium, RecursoCategoriumDto>
{
    public RecursoCategoriumsController(RecursoCategoriumService service) : base(service) { }
}
