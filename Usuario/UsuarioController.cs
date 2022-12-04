using Microsoft.AspNetCore.Mvc;

namespace Aterdigital.Usuarios;

[ApiController]
[Route("usuario")]
public class UsuarioController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public async void Get()
    {
    }
}
