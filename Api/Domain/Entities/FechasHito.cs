using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class FechasHito
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public int? Orden { get; set; }

    public string? Motivo { get; set; }

    public int? MilestoneId { get; set; }

    public virtual ICollection<Hito> Hitos { get; set; } = new List<Hito>();

    public virtual Hito? Milestone { get; set; }
}
