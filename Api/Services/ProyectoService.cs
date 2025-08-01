using Microsoft.EntityFrameworkCore;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using AutoMapper;

namespace TimesheetApi.Application.Services;

public class ProyectoService : CrudService<Proyecto, ProyectoDto>
{
    public ProyectoService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
