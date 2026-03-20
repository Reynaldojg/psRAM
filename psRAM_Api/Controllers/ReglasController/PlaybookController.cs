using Microsoft.AspNetCore.Mvc;
using psRAM_Application.Interfaces.IServices.IReglas;
using System.Threading.Tasks;

namespace psRAM_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlaybookController : ControllerBase
    {
        private readonly IPlaybookYAMLService _service;

        public PlaybookController(IPlaybookYAMLService service)
        {
            _service = service;
        }

        /// <summary>
        /// Crea un nuevo playbook YAML.
        /// </summary>
        [HttpPost("crear")]
        public async Task<IActionResult> Crear([FromBody] PlaybookYAMLDtos dto)
        {
            var result = await _service.CrearPlaybookAsync(dto);

            if (!result.IsSuccess)
                return BadRequest(result.Message);

            return Ok(result);
        }

        /// <summary>
        /// Obtiene todos los playbooks YAML registrados.
        /// </summary>
        [HttpGet("obtener-todos")]
        public async Task<IActionResult> ObtenerTodos()
        {
            var result = await _service.ObtenerTodosAsync();

            if (!result.IsSuccess)
                return NotFound(result.Message);

            return Ok(result);
        }
    }
}

