using FluentValidation;
using TimesheetApi.Application.DTOs;

namespace TimesheetApi.Application.Validators;

public class FeriadoDtoValidator : AbstractValidator<FeriadoDto>
{
    public FeriadoDtoValidator()
    {
        // Add validation rules as needed
    }
}
