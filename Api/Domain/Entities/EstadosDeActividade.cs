using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class EstadosDeActividade
{
    public int IdEstado { get; set; }

    public string? Nombre { get; set; }

    public int? Orden { get; set; }

    public virtual ICollection<ActividadesEstado> ActividadesEstados { get; set; } = new List<ActividadesEstado>();
}
