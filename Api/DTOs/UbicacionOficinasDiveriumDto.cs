namespace TimesheetApi.Application.DTOs;

public class UbicacionOficinasDiveriumDto
{
        public int IdUbicacion { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public int? Tolerancia { get; set; }
}
