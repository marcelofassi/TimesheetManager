using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class RecursoService : CrudService<Recurso, RecursoDto>
{
    public RecursoService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
