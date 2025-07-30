using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class User
{
    public Guid Id { get; set; }

    public string Username { get; set; } = null!;

    public string? PasswordHash { get; set; }

    public int? IdRecurso { get; set; }

    public virtual Recurso? IdRecursoNavigation { get; set; }
}
