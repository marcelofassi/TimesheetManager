using FluentValidation;
using TimesheetApi.Application.DTOs;

namespace TimesheetApi.Application.Validators;

public class ResourceToActivityDtoValidator : AbstractValidator<ResourceToActivityDto>
{
    public ResourceToActivityDtoValidator()
    {
        // Add validation rules as needed
    }
}
