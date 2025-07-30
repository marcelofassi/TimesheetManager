using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class ConfiguracionesController : CrudController<Configuracione, ConfiguracioneDto>
{
    public ConfiguracionesController(ConfiguracioneService service) : base(service) { }
}
