using TimesheetApi.Application.DTOs;
using TimesheetApi.Application.Services;

namespace TimesheetApi.Controllers;

public class UsersController : CrudController<User, UserDto>
{
    public UsersController(UserService service) : base(service) { }
}
