using Microsoft.AspNetCore.Mvc;
using psRAM_Application.Interfaces.IServices.IArtefactos;

namespace psRAM_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArchivoController : ControllerBase
    {
        private readonly IArchivoService _service;

        public ArchivoController(IArchivoService service)
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