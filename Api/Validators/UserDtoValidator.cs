using FluentValidation;
using TimesheetApi.Application.DTOs;

namespace TimesheetApi.Application.Validators;

public class UserDtoValidator : AbstractValidator<UserDto>
{
    public UserDtoValidator()
    {
        // Add validation rules as needed
    }
}
