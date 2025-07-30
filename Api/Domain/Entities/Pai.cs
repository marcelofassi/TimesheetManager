using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class Pai
{
    public int IdPais { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
