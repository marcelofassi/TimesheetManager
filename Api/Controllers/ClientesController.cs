using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class ClientesController : CrudController<Cliente, ClienteDto>
{
    public ClientesController(ClienteService service) : base(service) { }
}
