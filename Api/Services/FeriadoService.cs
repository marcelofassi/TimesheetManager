using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class FeriadoService : CrudService<Feriado, FeriadoDto>
{
    public FeriadoService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
