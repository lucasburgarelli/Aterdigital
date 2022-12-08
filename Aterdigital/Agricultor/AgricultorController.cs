using Aterdigital.Usuarios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aterdigital.Agricultores;

[ApiController]
[Route("agricultor")]
public class AgricultorController : ControllerBase
{
    private readonly AppDbContext context;
    public AgricultorController(AppDbContext dbContext)
    {
        context = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromServices] AppDbContext context)
    {
        var agricultores = await context.Agricultores.AsNoTracking().ToListAsync();

        return agricultores == null ? NotFound() : Ok(agricultores);
    }

    [HttpGet("/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromServices] AppDbContext context, Guid id)
    {
        var agricultor = await context.Agricultores.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);

        return agricultor == null ? NotFound() : Ok(agricultor);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] CreateAgricultorViewModel model)
    {
        if (!ModelState.IsValid) return BadRequest();

        var agricultor = new Agricultor(model);

        try
        {
            await context.Agricultores.AddAsync(agricultor);
            await context.SaveChangesAsync();
            return Created($"agricultor/{agricultor.Id}", agricultor);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPut("/{id}")]
    public async Task<IActionResult> PutAsync([FromServices] AppDbContext context, [FromBody] Agricultor model, Guid id)
    {
        if (!ModelState.IsValid) return BadRequest();

        var agricultor = await context.Agricultores.FirstOrDefaultAsync(x => x.Id == id);

        if (agricultor == null) return NotFound();

        try
        {
            // TODO update agricultor
            await context.SaveChangesAsync();
            return Ok(agricultor);
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpDelete("/{id}")]
    public async Task<IActionResult> DeleteAsync([FromServices] AppDbContext context, Guid id)
    {
        var agricultor = await context.Agricultores.FirstOrDefaultAsync(u => u.Id == id);

        try
        {
            context.Agricultores.Remove(agricultor);
            await context.SaveChangesAsync();

            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }
}