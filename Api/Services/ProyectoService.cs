using Microsoft.EntityFrameworkCore;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using AutoMapper;
using System.Linq;

namespace TimesheetApi.Application.Services;

public class ProyectoService : CrudService<Proyecto, ProyectoDto>
{
    public ProyectoService(DvrTimeSheetContext context, IMapper mapper) : base(context, mapper) { }

    public override async Task<ProyectoDto?> GetByIdAsync(object id) => await GetByIdAsync((int)id);

    public async Task<ProyectoDto?> GetByIdAsync(int id)
    {
        var entity = await _context.Proyectos
            .Include(p => p.ResourceToProjects)
                .ThenInclude(rtp => rtp.Resource)
            .Include(p => p.ProyectosTecnologias)
                .ThenInclude(pt => pt.IdTecnologiaNavigation)
            .FirstOrDefaultAsync(p => p.IdProyecto == id);

        if (entity == null) return null;

        var dto = _mapper.Map<ProyectoDto>(entity);
        dto.ResourceIds = entity.ResourceToProjects.Select(rtp => rtp.ResourceId).ToList();
        dto.TecnologiaIds = entity.ProyectosTecnologias.Select(pt => pt.IdTecnologia).ToList();
        return dto;
    }

    public override async Task<IEnumerable<ProyectoDto>> GetAllAsync()
    {
        var entities = await _context.Proyectos
            .Include(p => p.ResourceToProjects)
                .ThenInclude(rtp => rtp.Resource)
            .Include(p => p.ProyectosTecnologias)
                .ThenInclude(pt => pt.IdTecnologiaNavigation)
            .ToListAsync();

        var dtos = _mapper.Map<List<ProyectoDto>>(entities);

        for (int i = 0; i < entities.Count; i++)
        {
            dtos[i].ResourceIds = entities[i].ResourceToProjects.Select(rtp => rtp.ResourceId).ToList();
            dtos[i].TecnologiaIds = entities[i].ProyectosTecnologias.Select(pt => pt.IdTecnologia).ToList();
        }

        return dtos;
    }
}
