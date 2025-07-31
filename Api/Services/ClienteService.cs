using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class ClienteService : CrudService<Cliente, ClienteDto>
{
    public ClienteService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
