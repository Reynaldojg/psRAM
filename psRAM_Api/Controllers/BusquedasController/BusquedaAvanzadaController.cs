using Microsoft.AspNetCore.Mvc;
using psRAM_Application.Interfaces.IServices.IBusquedas;
using psRAM_Application.DTOS.BusquedasDtos;
using System.Threading.Tasks;

namespace psRAM_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusquedaAvanzadaController : ControllerBase
    {
        private readonly IBusquedaAvanzadaService _service;

        public BusquedaAvanzadaController(IBusquedaAvanzadaService service)
        {
            _service = service;
        }

        /// <summary>
        /// Ejecuta una búsqueda avanzada y la registra en la base de datos.
        /// </summary>
        [HttpPost("ejecutar")]
        public async Task<IActionResult> Ejecutar([FromBody] BusquedaAvanzadaDtos dto)
        {
            var result = await _service.EjecutarBusquedaAsync(dto);

            if (!result.IsSuccess)
                return BadRequest(result.Message);

            return Ok(result);
        }

        /// <summary>
        /// Obtiene una búsqueda avanzada por su Id.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(int id)
        {
            var result = await _service.ObtenerPorId(id);

            if (!result.IsSuccess)
                return NotFound(result.Message);

            return Ok(result);
        }
    }
}
