using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class CierreMeService : CrudService<CierreMe, CierreMeDto>
{
    public CierreMeService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
