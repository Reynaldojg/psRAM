using Microsoft.AspNetCore.Mvc;
using psRAM_Application.DTOS.AnalisisDTOS;
using psRAM_Application.Interfaces.IServices.IAnalisis;

namespace psRAM_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImagenMemoriaController : ControllerBase
    {
        private readonly IImagenMemoriaService _service;

        public ImagenMemoriaController(IImagenMemoriaService service)
        {
            _service = service;
        }

        [HttpPost("registrar")]
        public async Task<IActionResult> Registrar([FromBody] ImagenMemoriaDtos dto)
        {
            var result = await _service.RegistrarImagenAsync(dto);
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
    }
}