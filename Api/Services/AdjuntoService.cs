using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class AdjuntoService : CrudService<Adjunto, AdjuntoDto>
{
    public AdjuntoService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
