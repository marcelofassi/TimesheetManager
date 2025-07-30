namespace TimesheetApi.Application.DTOs;

public class JornadaDto
{
        public int IdJornada { get; set; }
        public int IdRecurso { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public DateOnly? FechaHoraCierre { get; set; }
        public decimal? TotalHoras { get; set; }
        public decimal? IntervalosDeTiempos { get; set; }
        public DateTime? FechaInforme { get; set; }
        public int? IdUbicacion { get; set; }
        public int? IdEstado { get; set; }
}
