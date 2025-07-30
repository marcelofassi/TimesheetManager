using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class UbicacionOficinasDiverium
{
    public int IdUbicacion { get; set; }

    public decimal? Latitud { get; set; }

    public decimal? Longitud { get; set; }

    public int? Tolerancia { get; set; }
}
