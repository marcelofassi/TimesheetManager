using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class RecursoCategoriumService : CrudService<RecursoCategorium, RecursoCategoriumDto>
{
    public RecursoCategoriumService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
