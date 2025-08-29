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

    public new async Task<ProyectoDto> CreateAsync(ProyectoDto dto)
    {
        var entity = _mapper.Map<Proyecto>(dto);
        _context.Proyectos.Add(entity);
        await _context.SaveChangesAsync();

        if (dto.IdRecursos != null)
        {
            foreach (var recursoId in dto.IdRecursos)
            {
                _context.ResourceToProjects.Add(new ResourceToProject
                {
                    ProjectId = entity.IdProyecto,
                    ResourceId = recursoId
                });
            }
        }

        if (dto.IdTecnologias != null)
        {
            foreach (var tecnologiaId in dto.IdTecnologias)
            {
                _context.ProyectosTecnologias.Add(new ProyectosTecnologia
                {
                    IdProyecto = entity.IdProyecto,
                    IdTecnologia = tecnologiaId
                });
            }
        }

        await _context.SaveChangesAsync();
        return _mapper.Map<ProyectoDto>(entity);
    }

    public new async Task<bool> UpdateAsync(int id, ProyectoDto dto)
    {
        var entity = await _context.Proyectos
            .Include(p => p.ResourceToProjects)
            .FirstOrDefaultAsync(p => p.IdProyecto == id);
        if (entity == null) return false;

        _mapper.Map(dto, entity);

        if (dto.IdRecursos != null)
        {
            var existingResourceIds = entity.ResourceToProjects.Select(r => r.ResourceId).ToList();
            var toAdd = dto.IdRecursos.Except(existingResourceIds);
            var toRemove = existingResourceIds.Except(dto.IdRecursos);

            _context.ResourceToProjects.RemoveRange(entity.ResourceToProjects.Where(r => toRemove.Contains(r.ResourceId)));
            foreach (var recursoId in toAdd)
            {
                entity.ResourceToProjects.Add(new ResourceToProject
                {
                    ProjectId = id,
                    ResourceId = recursoId
                });
            }
        }

        if (dto.IdTecnologias != null)
        {
            var existingTecnologias = await _context.ProyectosTecnologias.Where(t => t.IdProyecto == id).ToListAsync();
            var existingTecnologiaIds = existingTecnologias.Select(t => t.IdTecnologia).ToList();
            var toAdd = dto.IdTecnologias.Except(existingTecnologiaIds);
            var toRemove = existingTecnologiaIds.Except(dto.IdTecnologias);

            _context.ProyectosTecnologias.RemoveRange(existingTecnologias.Where(t => toRemove.Contains(t.IdTecnologia)));
            foreach (var tecnologiaId in toAdd)
            {
                _context.ProyectosTecnologias.Add(new ProyectosTecnologia
                {
                    IdProyecto = id,
                    IdTecnologia = tecnologiaId
                });
            }
        }

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<ProyectoDto?> GetDetalleAsync(int id)
    {
        var proyecto = await _context.Proyectos
            .Include(p => p.ResourceToProjects)
            .FirstOrDefaultAsync(p => p.IdProyecto == id);
        if (proyecto == null) return null;

        var dto = _mapper.Map<ProyectoDto>(proyecto);
        dto.IdRecursos = proyecto.ResourceToProjects.Select(r => r.ResourceId).ToList();
        dto.IdTecnologias = await _context.ProyectosTecnologias
            .Where(t => t.IdProyecto == id)
            .Select(t => t.IdTecnologia)
            .ToListAsync();
        return dto;
    }
}
