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
        var todo = await context.Usuarios.AsNoTracking().FirstOrDefaultAsync(usuario => usuario.Id == id);

        return todo == null ? NotFound() : Ok(todo);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] Usuario model)
    {
        if (!ModelState.IsValid) return BadRequest();

        var usuario = new Usuario();

        try
        {
            await context.Usuarios.AddAsync(usuario);
            await context.SaveChangesAsync();
            return Created($"usuario/{usuario.Id}", usuario);
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

        var usuario = await context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);

        if (usuario == null) return NotFound();

        try
        {
            // TODO update usuario
            await context.SaveChangesAsync();
            return Ok(usuario);
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpDelete("/{id}")]
    public async Task<IActionResult> DeleteAsync([FromServices] AppDbContext context, Guid id)
    {
        var usuario = await context.Usuarios.FirstOrDefaultAsync(u => u.Id == id);

        try
        {
            context.Usuarios.Remove(usuario);
            await context.SaveChangesAsync();

            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }
}