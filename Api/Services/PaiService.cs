using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class PaiService : CrudService<Pai, PaiDto>
{
    public PaiService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
