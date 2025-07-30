namespace TimesheetApi.Application.DTOs;

public class HitoDto
{
        public int IdHito { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public bool? Pago { get; set; }
        public string? Contexto { get; set; }
        public string? Estado { get; set; }
        public DateTime? FechaConcrecion { get; set; }
        public int? IdProyecto { get; set; }
        public int? IdFecha { get; set; }
}
