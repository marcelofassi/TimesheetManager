using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class ActividadesEstadosController : CrudController<ActividadesEstado, ActividadesEstadoDto>
{
    public ActividadesEstadosController(ActividadesEstadoService service) : base(service) { }
}
