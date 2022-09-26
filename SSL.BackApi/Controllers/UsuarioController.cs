using Microsoft.AspNetCore.Mvc;
using SSL.Common.Interfaces;

namespace SSL.BackApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            var usuario = usuarioService.Get(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }
    }
}
