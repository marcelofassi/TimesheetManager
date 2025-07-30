using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class Tecnologia
{
    public int IdTecnologia { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<RecursoTecnologium> RecursoTecnologia { get; set; } = new List<RecursoTecnologium>();
}
