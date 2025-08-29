

using System.Collections.Generic;

namespace TimesheetApi.Application.DTOs;

public class ProyectoDto
{
    public int IdProyecto { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public DateTime? FechaAlta { get; set; }
    public DateTime? FechaCierre { get; set; }


    public List<int> ResourceIds { get; set; } = new();
    public List<int> TecnologiaIds { get; set; } = new();
    public List<ResourceToProjectDto>? ResourceToProjects { get; set; }
    public List<TecnologiaDto>? Tecnologias { get; set; }

    public List<int>? IdTecnologias { get; set; }
    public List<int>? IdRecursos { get; set; }

}
