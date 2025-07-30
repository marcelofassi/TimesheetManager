using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class ActividadesEstado
{
    public int IdActividadEstados { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaEgreso { get; set; }

    public int? NroDeEstado { get; set; }

    public int? IdActividad { get; set; }

    public int? IdEstado { get; set; }

    public virtual Actividade? IdActividadNavigation { get; set; }

    public virtual EstadosDeActividade? IdEstadoNavigation { get; set; }
}
