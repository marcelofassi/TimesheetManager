using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class ResourceToProject
{
    public int ProjectId { get; set; }

    public int ResourceId { get; set; }

    public int Id { get; set; }

    public virtual Proyecto Project { get; set; } = null!;

    public virtual Recurso Resource { get; set; } = null!;
}
