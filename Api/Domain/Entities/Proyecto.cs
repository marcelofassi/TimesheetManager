using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class Proyecto
{
    public int IdProyecto { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaCierre { get; set; }

    public int? HorasVendidas { get; set; }

    public int? HorasPresupuestoInterno { get; set; }

    public decimal? Presupuesto { get; set; }

    public decimal? PresupuestoInterno { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime? FechaFinalizacion { get; set; }

    public int? IdCliente { get; set; }

    public bool? InformarEnReporteStatus { get; set; }

    public int? PresupuestoHorasMensualInterno { get; set; }

    public int? PresupuestoHorasMensualCliente { get; set; }

    public bool? EsFacturable { get; set; }

    public virtual ICollection<Actividade> Actividades { get; set; } = new List<Actividade>();

    public virtual ICollection<Hito> Hitos { get; set; } = new List<Hito>();

    public virtual ICollection<HojaDeTiempo> HojaDeTiempos { get; set; } = new List<HojaDeTiempo>();

    public virtual Cliente? IdClienteNavigation { get; set; }
}
