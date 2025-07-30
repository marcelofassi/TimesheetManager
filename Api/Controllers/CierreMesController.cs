using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class CierreMesController : CrudController<CierreMe, CierreMeDto>
{
    public CierreMesController(CierreMeService service) : base(service) { }
}
