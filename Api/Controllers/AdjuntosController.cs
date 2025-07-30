using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class AdjuntosController : CrudController<Adjunto, AdjuntoDto>
{
    public AdjuntosController(AdjuntoService service) : base(service) { }
}
