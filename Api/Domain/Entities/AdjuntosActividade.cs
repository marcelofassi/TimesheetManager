using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class AdjuntosActividade
{
    public int IdActividad { get; set; }

    public int IdAdjunto { get; set; }

    public virtual Actividade IdActividadNavigation { get; set; } = null!;

    public virtual Adjunto IdAdjuntoNavigation { get; set; } = null!;
}
