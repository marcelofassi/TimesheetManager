using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class ConfiguracioneService : CrudService<Configuracione, ConfiguracioneDto>
{
    public ConfiguracioneService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
