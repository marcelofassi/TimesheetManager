namespace TimesheetApi.Application.DTOs;

public class ActividadeDto
{
        public int IdActividad { get; set; }
        public int? IdActividadPadre { get; set; }
        public int? IdProyecto { get; set; }
        public string? Nombre { get; set; }
        public string? Detalle { get; set; }
        public decimal? HorasEstimadas { get; set; }
        public decimal? HorasReales { get; set; }
        public DateTime? FechaBaja { get; set; }
}
