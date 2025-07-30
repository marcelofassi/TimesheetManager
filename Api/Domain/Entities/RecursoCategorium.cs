using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class RecursoCategorium
{
    public int Id { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaBaja { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdRecurso { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual Recurso? IdRecursoNavigation { get; set; }
}
