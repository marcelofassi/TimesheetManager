namespace TimesheetApi.Application.DTOs;

public class ActividadesEstadoDto
{
        public int IdActividadEstados { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaEgreso { get; set; }
        public int? NroDeEstado { get; set; }
        public int? IdActividad { get; set; }
        public int? IdEstado { get; set; }
}
