namespace TimesheetApi.Application.DTOs;

public class EstadosRecursoDto
{
        public int IdEstadoRecurso { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Activo { get; set; }
}
