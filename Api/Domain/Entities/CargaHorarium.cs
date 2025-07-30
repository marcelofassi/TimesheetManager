using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class CargaHorarium
{
    public int IdCargaHoraria { get; set; }

    public int? IdRecurso { get; set; }

    public decimal? CargaHoraria { get; set; }

    public DateTime? VigenteDesde { get; set; }
}
