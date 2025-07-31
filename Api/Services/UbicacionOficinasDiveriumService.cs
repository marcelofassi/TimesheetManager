using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class UbicacionOficinasDiveriumService : CrudService<UbicacionOficinasDiverium, UbicacionOficinasDiveriumDto>
{
    public UbicacionOficinasDiveriumService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
