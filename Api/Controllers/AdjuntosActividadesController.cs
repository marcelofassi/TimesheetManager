using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class AdjuntosActividadesController : CrudController<AdjuntosActividade, AdjuntosActividadeDto>
{
    public AdjuntosActividadesController(AdjuntosActividadeService service) : base(service) { }
}
