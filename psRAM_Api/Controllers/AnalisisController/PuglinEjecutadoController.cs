using Microsoft.AspNetCore.Mvc;
using psRAM_Application.Interfaces.IServices.IAnalisis;

namespace psRAM_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PluginEjecutadoController : ControllerBase
    {
        private readonly IPuglinEjecutadoService _service;

        public PluginEjecutadoController(IPuglinEjecutadoService service)
        {
            _service = service;
        }

        [HttpPost("ejecutar")]
        public async Task<IActionResult> Ejecutar([FromQuery] string nombrePlugin, [FromQuery] int resultadoAnalisisId)
        {
            var result = await _service.EjecutarPuglinAsync(nombrePlugin, resultadoAnalisisId);
            if (!result.IsSuccess) return BadRequest(result.Message);
            return Ok(result);
        }

        [HttpGet("porResultado/{resultadoAnalisisId}")]
        public async Task<IActionResult> ObtenerPorResultado(int resultadoAnalisisId)
        {
            var result = await _service.ObtenerPorResultadoAnalisis(resultadoAnalisisId);
            if (!result.IsSuccess) return NotFound(result.Message);
            return Ok(result);
        }
    }
}
