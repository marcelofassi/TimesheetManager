namespace TimesheetApi.Application.DTOs;

public class FechasHitoDto
{
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Orden { get; set; }
        public string? Motivo { get; set; }
        public int? MilestoneId { get; set; }
}
