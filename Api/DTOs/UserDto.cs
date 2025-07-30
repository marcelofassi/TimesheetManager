namespace TimesheetApi.Application.DTOs;

public class UserDto
{
        public Guid Id { get; set; }
        public string Username { get; set; } = null!;
        public string? PasswordHash { get; set; }
        public int? IdRecurso { get; set; }
}
