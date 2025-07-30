using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class JornadasController : CrudController<Jornada, JornadaDto>
{
    public JornadasController(JornadaService service) : base(service) { }
}
