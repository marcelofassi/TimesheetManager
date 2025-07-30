using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class EstadosRecurso
{
    public int IdEstadoRecurso { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool Activo { get; set; }
}
