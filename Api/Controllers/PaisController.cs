using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class PaisController : CrudController<Pai, PaiDto>
{
    public PaisController(PaiService service) : base(service) { }
}
