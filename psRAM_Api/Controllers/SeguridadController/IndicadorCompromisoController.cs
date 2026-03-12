using Microsoft.AspNetCore.Mvc;
using psRAM_Application.Interfaces.IServices.ISeguridad;
using System;
using System.Threading.Tasks;

namespace psRAM_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IndicadorCompromisoController : ControllerBase
    {
        private readonly IIndicadorCompromisoService _service;

        public IndicadorCompromisoController(IIndicadorCompromisoService service)
        {
            _service = service;
        }

        /// <summary>
        /// Obtiene los indicadores de compromiso filtrados por rango de fechas.
        /// </summary>
        /// <param name="desde">Fecha inicial del rango</param>
        /// <param name="hasta">Fecha final del rango</param>
        /// <returns>Lista de indicadores dentro del rango</returns>
        [HttpGet("porFecha")]
        public async Task<IActionResult> ObtenerPorFecha([FromQuery] DateTime desde, [FromQuery] DateTime hasta)
        {
            var result = await _service.ObtenerPorFecha(desde, hasta);

            if (!result.IsSuccess)
                return BadRequest(result.Message);

            return Ok(result);
        }
    }
}
