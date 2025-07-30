using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class HitoService : CrudService<Hito, HitoDto>
{
    public HitoService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
