using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class Actividade
{
    public int IdActividad { get; set; }

    public int? IdActividadPadre { get; set; }

    public int? IdProyecto { get; set; }

    public string? Nombre { get; set; }

    public string? Detalle { get; set; }

    public decimal? HorasEstimadas { get; set; }

    public decimal? HorasReales { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual ICollection<ActividadesEstado> ActividadesEstados { get; set; } = new List<ActividadesEstado>();

    public virtual ICollection<HojaDeTiempo> HojaDeTiempos { get; set; } = new List<HojaDeTiempo>();

    public virtual Actividade? IdActividadPadreNavigation { get; set; }

    public virtual Proyecto? IdProyectoNavigation { get; set; }

    public virtual ICollection<Actividade> InverseIdActividadPadreNavigation { get; set; } = new List<Actividade>();
}
