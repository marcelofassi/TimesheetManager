using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class TecnologiasController : CrudController<Tecnologia, TecnologiaDto>
{
    public TecnologiasController(TecnologiaService service) : base(service) { }
}
