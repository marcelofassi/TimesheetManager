using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? NombreRazonSocial { get; set; }

    public string? Codigo { get; set; }

    public string? Domicilio { get; set; }

    public DateTime? FechaBaja { get; set; }

    public int? IdPais { get; set; }

    public DateTime? FechaAlta { get; set; }

    public bool? NoVolverPreguntarNotifica { get; set; }

    public virtual Pai? IdPaisNavigation { get; set; }

    public virtual ICollection<Proyecto> Proyectos { get; set; } = new List<Proyecto>();
}
