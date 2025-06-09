using Microsoft.AspNetCore.Mvc;
using MiApiJuego.Models;
using MiApiJuego.Services;

namespace MiApiJuego.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JugadorController : ControllerBase
    {
        private readonly JugadorService _jugadorService;

        public JugadorController(JugadorService jugadorService)
        {
            _jugadorService = jugadorService;
        }

        [HttpGet]
        public ActionResult<List<Jugador>> Get() =>
            _jugadorService.Obtener();

        [HttpPost]
        public ActionResult<Jugador> Post(Jugador jugador)
        {
            _jugadorService.Crear(jugador);
            return CreatedAtAction(nameof(Get), new { id = jugador.Id }, jugador);
        }
    }
}
