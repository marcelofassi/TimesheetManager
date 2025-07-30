using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class ProyectosTecnologiasController : CrudController<ProyectosTecnologia, ProyectosTecnologiaDto>
{
    public ProyectosTecnologiasController(ProyectosTecnologiaService service) : base(service) { }
}
