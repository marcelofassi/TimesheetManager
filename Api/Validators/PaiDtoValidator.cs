using FluentValidation;
using TimesheetApi.Application.DTOs;

namespace TimesheetApi.Application.Validators;

public class PaiDtoValidator : AbstractValidator<PaiDto>
{
    public PaiDtoValidator()
    {
        // Add validation rules as needed
    }
}
