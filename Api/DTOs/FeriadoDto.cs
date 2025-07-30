namespace TimesheetApi.Application.DTOs;

public class FeriadoDto
{
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; } = null!;
}
