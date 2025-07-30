using Microsoft.EntityFrameworkCore;
using TimesheetApi.Domain;
using TimesheetApi.Domain.Entities;
using TimesheetApi.Application.DTOs;
using AutoMapper;

namespace TimesheetApi.Application.Services;

public class ProyectoService
{
    private readonly DvrTimeSheetContext _context;
    private readonly IMapper _mapper;

    public ProyectoService(DvrTimeSheetContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProyectoDto>> GetAllAsync()
    {
        var proyectos = await _context.Proyectos.ToListAsync();
        return _mapper.Map<IEnumerable<ProyectoDto>>(proyectos);
    }

    public async Task<ProyectoDto?> GetByIdAsync(int id)
    {
        var proyecto = await _context.Proyectos.FindAsync(id);
        return proyecto == null ? null : _mapper.Map<ProyectoDto>(proyecto);
    }

    public async Task<ProyectoDto> CreateAsync(ProyectoDto dto)
    {
        var entidad = _mapper.Map<Proyecto>(dto);
        _context.Proyectos.Add(entidad);
        await _context.SaveChangesAsync();
        return _mapper.Map<ProyectoDto>(entidad);
    }

    public async Task<bool> UpdateAsync(int id, ProyectoDto dto)
    {
        var proyecto = await _context.Proyectos.FindAsync(id);
        if (proyecto == null) return false;

        _mapper.Map(dto, proyecto);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var proyecto = await _context.Proyectos.FindAsync(id);
        if (proyecto == null) return false;

        _context.Proyectos.Remove(proyecto);
        await _context.SaveChangesAsync();
        return true;
    }
}
