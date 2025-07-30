using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class ResourceToProjectService : CrudService<ResourceToProject, ResourceToProjectDto>
{
    public ResourceToProjectService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
