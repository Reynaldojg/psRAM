using Microsoft.AspNetCore.Mvc;
using psRAM_Application.Interfaces.IServices.ISeguridad;
using psRAM_Application.DTOS.SeguridadDtos;
using System.Threading.Tasks;

namespace psRAM_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValidacionExternaController : ControllerBase
    {
        private readonly IValidacionExternaService _service;

        public ValidacionExternaController(IValidacionExternaService service)
        {
            _service = service;
        }

        /// <summary>
        /// Registra un nuevo resultado de validación externa.
        /// </summary>
        [HttpPost("registrar")]
        public async Task<IActionResult> Registrar([FromBody] ValidacionExternaDtos dto)
        {
            var result = await _service.RegistrarResultadoAsync(dto);

            if (!result.IsSuccess)
                return BadRequest(result.Message);

            return Ok(result);
        }

        /// <summary>
        /// Obtiene todas las validaciones externas asociadas a un artefacto.
        /// </summary>
        [HttpGet("porArtefacto/{artefacto}")]
        public async Task<IActionResult> ObtenerPorArtefacto(string artefacto)
        {
            var result = await _service.ObtenerPorArtefacto(artefacto);

            if (!result.IsSuccess)
                return NotFound(result.Message);

            return Ok(result);
        }
    }
}
