using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class EstadosDeActividadeService : CrudService<EstadosDeActividade, EstadosDeActividadeDto>
{
    public EstadosDeActividadeService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
