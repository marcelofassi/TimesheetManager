namespace TimesheetApi.Application.DTOs;

public class CargaHorariumDto
{
        public int IdCargaHoraria { get; set; }
        public int? IdRecurso { get; set; }
        public decimal? CargaHoraria { get; set; }
        public DateTime? VigenteDesde { get; set; }
}
