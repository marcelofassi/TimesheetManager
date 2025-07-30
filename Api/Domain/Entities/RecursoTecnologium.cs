using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class RecursoTecnologium
{
    public int Id { get; set; }

    public DateTime? FechaInicio { get; set; }

    public int? Nivel { get; set; }

    public int? IdRecurso { get; set; }

    public int? IdTecnologia { get; set; }

    public virtual Recurso? IdRecursoNavigation { get; set; }

    public virtual Tecnologia? IdTecnologiaNavigation { get; set; }
}
