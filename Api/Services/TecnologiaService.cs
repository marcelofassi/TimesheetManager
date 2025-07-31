using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class TecnologiaService : CrudService<Tecnologia, TecnologiaDto>
{
    public TecnologiaService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
