using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class HojaDeTiempoService : CrudService<HojaDeTiempo, HojaDeTiempoDto>
{
    public HojaDeTiempoService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
