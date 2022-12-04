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

    [HttpGet("/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromServices] AppDbContext context, Guid id)
    {
        var agricultor = await context.Agricultores.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);

        return agricultor == null ? NotFound() : Ok(agricultor);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] Usuario model)
    {
        if (!ModelState.IsValid) return BadRequest();

        var agricultor = new Agricultor();

        try
        {
            await context.Agricultores.AddAsync(agricultor);
            await context.SaveChangesAsync();
            return Created($"agricultor/{agricultor.Id}", agricultor);
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpPut("/{id}")]
    public async Task<IActionResult> PutAsync([FromServices] AppDbContext context, [FromBody] Usuario model, Guid id)
    {
        if (!ModelState.IsValid) return BadRequest();

        var agricultor = await context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);

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
            context.Usuarios.Remove(agricultor);
            await context.SaveChangesAsync();

            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }
}