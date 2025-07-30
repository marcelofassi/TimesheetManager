// Application/DTOs/ProyectoDto.cs
namespace TimesheetApi.Application.DTOs;

public class ProyectoDto
{
    public int IdProyecto { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public DateTime? FechaAlta { get; set; }
    public DateTime? FechaCierre { get; set; }
}

