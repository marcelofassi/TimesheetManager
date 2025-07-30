using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class FechasHitoService : CrudService<FechasHito, FechasHitoDto>
{
    public FechasHitoService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
