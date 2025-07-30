using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class ProyectosTecnologiaService : CrudService<ProyectosTecnologia, ProyectosTecnologiaDto>
{
    public ProyectosTecnologiaService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
