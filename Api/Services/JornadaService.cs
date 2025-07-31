using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class JornadaService : CrudService<Jornada, JornadaDto>
{
    public JornadaService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
