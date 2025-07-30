using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class CargaHorariumsController : CrudController<CargaHorarium, CargaHorariumDto>
{
    public CargaHorariumsController(CargaHorariumService service) : base(service) { }
}
