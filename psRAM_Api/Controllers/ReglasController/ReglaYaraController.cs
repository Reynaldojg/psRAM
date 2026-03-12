using Microsoft.AspNetCore.Mvc;
using psRAM_Application.Interfaces.IServices.IReglas;
using psRAM_Application.DTOS.ReglasDtos;
using System.Threading.Tasks;

namespace psRAM_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReglaYaraController : ControllerBase
    {
        private readonly IReglaYARAService _service;

        public ReglaYaraController(IReglaYARAService service)
        {
            _service = service;
        }

        /// <summary>
        /// Crea una nueva regla YARA.
        /// </summary>
        [HttpPost("crear")]
        public async Task<IActionResult> Crear([FromBody] ReglaYARADtos dto)
        {
            var result = await _service.CrearReglaAsync(dto);

            if (!result.IsSuccess)
                return BadRequest(result.Message);

            return Ok(result);
        }

        /// <summary>
        /// Obtiene todas las reglas YARA registradas.
        /// </summary>
        [HttpGet("obtener-todas")]
        public async Task<IActionResult> ObtenerTodas()
        {
            var result = await _service.ObtenerTodasAsync();

            if (!result.IsSuccess)
                return NotFound(result.Message);

            return Ok(result);
        }
    }
}
