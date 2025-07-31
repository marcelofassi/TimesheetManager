using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class ResourceToActivityService : CrudService<ResourceToActivity, ResourceToActivityDto>
{
    public ResourceToActivityService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
