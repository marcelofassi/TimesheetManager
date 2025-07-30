using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class ActividadesEstadoService : CrudService<ActividadesEstado, ActividadesEstadoDto>
{
    public ActividadesEstadoService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
