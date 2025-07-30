using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class CierreMe
{
    public int Id { get; set; }

    public int? Mes { get; set; }

    public int? Anio { get; set; }

    public string? Estado { get; set; }
}
