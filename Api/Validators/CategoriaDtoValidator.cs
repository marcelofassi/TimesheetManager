using FluentValidation;
using TimesheetApi.Application.DTOs;

namespace TimesheetApi.Application.Validators;

public class CategoriaDtoValidator : AbstractValidator<CategoriaDto>
{
    public CategoriaDtoValidator()
    {
        // Add validation rules as needed
    }
}
