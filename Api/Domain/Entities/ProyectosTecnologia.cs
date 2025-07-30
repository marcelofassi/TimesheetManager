using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class ProyectosTecnologia
{
    public int IdProyecto { get; set; }

    public int IdTecnologia { get; set; }

    public virtual Proyecto IdProyectoNavigation { get; set; } = null!;

    public virtual Tecnologia IdTecnologiaNavigation { get; set; } = null!;
}
