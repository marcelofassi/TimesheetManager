using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class EstadosDeActividadesController : CrudController<EstadosDeActividade, EstadosDeActividadeDto>
{
    public EstadosDeActividadesController(EstadosDeActividadeService service) : base(service) { }
}
