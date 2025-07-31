using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class CategoriasController : CrudController<Categoria, CategoriaDto>
{
    public CategoriasController(CategoriaService service) : base(service) { }
}
