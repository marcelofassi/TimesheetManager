using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class ActividadesController : CrudController<Actividade, ActividadeDto>
{
    public ActividadesController(ActividadeService service) : base(service) { }
}
