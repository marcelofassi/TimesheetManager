using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class ActividadeService : CrudService<Actividade, ActividadeDto>
{
    public ActividadeService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
