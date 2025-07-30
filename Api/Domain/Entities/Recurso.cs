using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class Recurso
{
    public int IdRecurso { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public bool? UsaSeguridadIntegradaAd { get; set; }

    public string? NombreCompleto { get; set; }

    public decimal? MinHorasDia { get; set; }

    public decimal? MinHorasMes { get; set; }

    /// <summary>
    /// GUI del usuario en el active directory
    /// </summary>
    public string? AdGui { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime? FechaInicio { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<CostoRecurso> CostoRecursos { get; set; } = new List<CostoRecurso>();

    public virtual ICollection<Jornada> Jornada { get; set; } = new List<Jornada>();

    public virtual ICollection<RecursoCategorium> RecursoCategoria { get; set; } = new List<RecursoCategorium>();

    public virtual ICollection<RecursoTecnologium> RecursoTecnologia { get; set; } = new List<RecursoTecnologium>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
