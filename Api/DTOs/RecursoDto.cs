namespace TimesheetApi.Application.DTOs;

public class RecursoDto
{
        public int IdRecurso { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public bool? UsaSeguridadIntegradaAd { get; set; }
        public string? NombreCompleto { get; set; }
        public decimal? MinHorasDia { get; set; }
        public decimal? MinHorasMes { get; set; }
        public string? AdGui { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaInicio { get; set; }
        public string? Email { get; set; }
}
