using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class Jornada
{
    public int IdJornada { get; set; }

    public int IdRecurso { get; set; }

    public DateTime? Fecha { get; set; }

    public DateTime? FechaHoraInicio { get; set; }

    public DateTime? FechaHoraFin { get; set; }

    public DateOnly? FechaHoraCierre { get; set; }

    public decimal? TotalHoras { get; set; }

    public decimal? IntervalosDeTiempos { get; set; }

    public DateTime? FechaInforme { get; set; }

    public int? IdUbicacion { get; set; }

    public int? IdEstado { get; set; }

    public virtual ICollection<HojaDeTiempo> HojaDeTiempos { get; set; } = new List<HojaDeTiempo>();

    public virtual Recurso IdRecursoNavigation { get; set; } = null!;
}
