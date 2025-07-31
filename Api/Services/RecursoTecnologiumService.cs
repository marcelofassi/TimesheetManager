using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class RecursoTecnologiumService : CrudService<RecursoTecnologium, RecursoTecnologiumDto>
{
    public RecursoTecnologiumService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
