using Microsoft.AspNetCore.Mvc;
using psRAM_Application.Interfaces.IServices.IArtefactos;

namespace psRAM_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModuloController : ControllerBase
    {
        private readonly IModuloMaliciosoService _service;

        public ModuloController(IModuloMaliciosoService service)
        {
            _service = service;
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
