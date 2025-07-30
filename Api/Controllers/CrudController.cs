using Microsoft.AspNetCore.Mvc;
using TimesheetApi.Application.Services;
using System.Reflection;

namespace TimesheetApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class CrudController<TEntity, TDto> : ControllerBase
    where TEntity : class, new()
    where TDto : class
{
    protected readonly CrudService<TEntity, TDto> _service;
    private readonly PropertyInfo _idProperty;

    protected CrudController(CrudService<TEntity, TDto> service)
    {
        _service = service;
        _idProperty = typeof(TDto).GetProperties().First(p => p.Name.StartsWith("Id"));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await _service.GetByIdAsync(id);
        return result == null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TDto dto)
    {
        var created = await _service.CreateAsync(dto);
        var id = _idProperty.GetValue(created);
        return CreatedAtAction(nameof(GetById), new { id }, created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] TDto dto)
    {
        var success = await _service.UpdateAsync(id, dto);
        return success ? NoContent() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await _service.DeleteAsync(id);
        return success ? NoContent() : NotFound();
    }
}
