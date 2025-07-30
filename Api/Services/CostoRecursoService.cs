using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class CostoRecursoService : CrudService<CostoRecurso, CostoRecursoDto>
{
    public CostoRecursoService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
