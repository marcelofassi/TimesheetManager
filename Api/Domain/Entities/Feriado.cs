using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class Feriado
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public string Descripcion { get; set; } = null!;
}
