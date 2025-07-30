using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class AdjuntosActividadeService : CrudService<AdjuntosActividade, AdjuntosActividadeDto>
{
    public AdjuntosActividadeService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
