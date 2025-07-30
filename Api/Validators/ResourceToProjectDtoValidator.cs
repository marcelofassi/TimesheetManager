using FluentValidation;
using TimesheetApi.Application.DTOs;

namespace TimesheetApi.Application.Validators;

public class ResourceToProjectDtoValidator : AbstractValidator<ResourceToProjectDto>
{
    public ResourceToProjectDtoValidator()
    {
        // Add validation rules as needed
    }
}
