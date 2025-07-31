using TimesheetApi.Application.DTOs;
using AutoMapper;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;

namespace TimesheetApi.Application.Services;

public class CategoriaService : CrudService<Categoria, CategoriaDto>
{
    public CategoriaService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }
}
