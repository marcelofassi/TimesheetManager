using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class HojaDeTiempo
{
    public int IdHojaDeTiempo { get; set; }

    public int IdJornada { get; set; }

    public int IdActividad { get; set; }

    public int IdProyecto { get; set; }

    public string? Notas { get; set; }

    public decimal CantidadDeHoras { get; set; }

    public virtual Actividade IdActividadNavigation { get; set; } = null!;

    public virtual Jornada IdJornadaNavigation { get; set; } = null!;

    public virtual Proyecto IdProyectoNavigation { get; set; } = null!;
}
