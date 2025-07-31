using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class UserService : CrudService<User, UserDto>
{
    public UserService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
