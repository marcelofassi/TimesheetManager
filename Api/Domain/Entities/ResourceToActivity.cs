using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class ResourceToActivity
{
    public int ActivityId { get; set; }

    public int ResourceId { get; set; }

    public virtual Actividade Activity { get; set; } = null!;

    public virtual Recurso Resource { get; set; } = null!;
}
