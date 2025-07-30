using System;
using System.Collections.Generic;

namespace TimesheetApi.Domain.Entities;

public partial class Adjunto
{
    public int IdAdjunto { get; set; }

    public string? NombreArchivo { get; set; }

    public string? Path { get; set; }
}
