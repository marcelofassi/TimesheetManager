using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<RecursoCategorium> RecursoCategoria { get; set; } = new List<RecursoCategorium>();
}
