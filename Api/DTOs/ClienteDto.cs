namespace TimesheetApi.Application.DTOs;

public class ClienteDto
{
        public int IdCliente { get; set; }
        public string? NombreRazonSocial { get; set; }
        public string? Codigo { get; set; }
        public string? Domicilio { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? IdPais { get; set; }
        public DateTime? FechaAlta { get; set; }
        public bool? NoVolverPreguntarNotifica { get; set; }
}
