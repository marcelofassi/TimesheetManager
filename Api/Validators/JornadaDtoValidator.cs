using FluentValidation;
using TimesheetApi.Application.DTOs;

namespace TimesheetApi.Application.Validators;

public class JornadaDtoValidator : AbstractValidator<JornadaDto>
{
    public JornadaDtoValidator()
    {
        // Add validation rules as needed
    }
}
