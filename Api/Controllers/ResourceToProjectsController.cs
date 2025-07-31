using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class ResourceToProjectsController : CrudController<ResourceToProject, ResourceToProjectDto>
{
    public ResourceToProjectsController(ResourceToProjectService service) : base(service) { }
}
