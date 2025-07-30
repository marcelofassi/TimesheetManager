namespace TimesheetApi.Application.DTOs;

public class CostoRecursoDto
{
        public int IdCostoRecurso { get; set; }
        public int? Mes { get; set; }
        public int? Año { get; set; }
        public decimal? Costo { get; set; }
        public int? IdRecurso { get; set; }
}
