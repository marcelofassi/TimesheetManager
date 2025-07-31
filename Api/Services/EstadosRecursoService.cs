using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class EstadosRecursoService : CrudService<EstadosRecurso, EstadosRecursoDto>
{
    public EstadosRecursoService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
