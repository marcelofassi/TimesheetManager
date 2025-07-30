using FluentValidation;
using TimesheetApi.Application.DTOs;

namespace TimesheetApi.Application.Validators;

public class ProyectoDtoValidator : AbstractValidator<ProyectoDto>
{
    public ProyectoDtoValidator()
    {
        RuleFor(x => x.Nombre)
            .NotEmpty().WithMessage("El nombre es obligatorio")
            .MaximumLength(150).WithMessage("El nombre no debe superar los 150 caracteres");

        RuleFor(x => x.Descripcion)
            .MaximumLength(500).WithMessage("La descripción no debe superar los 500 caracteres");

        RuleFor(x => x.FechaAlta)
            .LessThanOrEqualTo(DateTime.Today).WithMessage("La fecha de alta no puede ser futura");

        RuleFor(x => x.FechaCierre)
            .GreaterThanOrEqualTo(x => x.FechaAlta.GetValueOrDefault())
            .When(x => x.FechaCierre.HasValue && x.FechaAlta.HasValue)
            .WithMessage("La fecha de cierre no puede ser anterior a la fecha de alta");
    }
}
