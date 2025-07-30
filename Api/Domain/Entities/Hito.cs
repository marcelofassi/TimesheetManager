using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class Hito
{
    public int IdHito { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public bool? Pago { get; set; }

    public string? Contexto { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaConcrecion { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdFecha { get; set; }

    public virtual ICollection<FechasHito> FechasHitos { get; set; } = new List<FechasHito>();

    public virtual FechasHito? IdFechaNavigation { get; set; }

    public virtual Proyecto? IdProyectoNavigation { get; set; }
}
