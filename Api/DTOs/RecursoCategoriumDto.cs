namespace TimesheetApi.Application.DTOs;

public class RecursoCategoriumDto
{
        public int Id { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdRecurso { get; set; }
}
