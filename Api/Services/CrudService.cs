using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TimesheetApi.Domain;

namespace TimesheetApi.Application.Services;

public class CrudService<TEntity, TDto>
    where TEntity : class, new()
    where TDto : class
{
    protected readonly DvrTimeSheetContext _context;
    protected readonly IMapper _mapper;
    private readonly DbSet<TEntity> _dbSet;
    private readonly PropertyInfo _idProperty;

    public CrudService(DvrTimeSheetContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
        _dbSet = context.Set<TEntity>();
        _idProperty = typeof(TEntity).GetProperties().First(p => p.Name.StartsWith("Id") && !p.Name.Contains("Navigation"));
    }

    protected object GetEntityId(TEntity entity) => _idProperty.GetValue(entity)!;

    public async Task<IEnumerable<TDto>> GetAllAsync()
    {
        var list = await _dbSet.ToListAsync();
        return _mapper.Map<IEnumerable<TDto>>(list);
    }

    public async Task<TDto?> GetByIdAsync(object id)
    {
        var entity = await _dbSet.FindAsync(id);
        return entity == null ? null : _mapper.Map<TDto>(entity);
    }

    public async Task<TDto> CreateAsync(TDto dto)
    {
        var entity = _mapper.Map<TEntity>(dto);
        _dbSet.Add(entity);
        await _context.SaveChangesAsync();
        return _mapper.Map<TDto>(entity);
    }

    public async Task<bool> UpdateAsync(object id, TDto dto)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null) return false;
        _mapper.Map(dto, entity);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(object id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity == null) return false;
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
        return true;
    }
}
