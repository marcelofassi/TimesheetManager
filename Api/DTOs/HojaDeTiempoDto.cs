namespace TimesheetApi.Application.DTOs;

public class HojaDeTiempoDto
{
        public int IdHojaDeTiempo { get; set; }
        public int IdJornada { get; set; }
        public int IdActividad { get; set; }
        public int IdProyecto { get; set; }
        public string? Notas { get; set; }
        public decimal CantidadDeHoras { get; set; }
}
