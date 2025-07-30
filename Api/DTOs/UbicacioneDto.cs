namespace TimesheetApi.Application.DTOs;

public class UbicacioneDto
{
        public int IdUbicacion { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Activo { get; set; }
}
