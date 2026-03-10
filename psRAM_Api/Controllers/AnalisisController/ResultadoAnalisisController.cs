using Microsoft.AspNetCore.Mvc;
using psRAM_Application.DTOS.AnalisisDTOS;
using psRAM_Application.Interfaces.IServices.IAnalisis;

namespace psRAM_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResultadoAnalisisController : ControllerBase
    {
        private readonly IResultadoAnalisisService _service;

        public ResultadoAnalisisController(IResultadoAnalisisService service)
        {
            _service = service;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> Crear([FromBody] ResultadoAnalisisDto dto)
        {
            var result = await _service.CrearAsync(dto);
            if (!result.IsSuccess) return BadRequest(result.Message);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(int id)
        {
            var result = await _service.ObtenerPorIdAsync(id);
            if (!result.IsSuccess) return NotFound(result.Message);
            return Ok(result);
        }

        [HttpGet("todos")]
        public async Task<IActionResult> ObtenerTodos()
        {
            var result = await _service.ObtenerTodosAsync();
            if (!result.IsSuccess) return BadRequest(result.Message);
            return Ok(result);
        }
    }
}
