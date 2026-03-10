using Microsoft.AspNetCore.Mvc;
using psRAM_Application.Interfaces.IServices.IAnalisis;
using psRAM_Domain.Enums;

namespace psRAM_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExportacionController : ControllerBase
    {
        private readonly IExportacionService _service;

        public ExportacionController(IExportacionService service)
        {
            _service = service;
        }

        [HttpPost("exportar")]
        public async Task<IActionResult> Exportar([FromQuery] int resultadoAnalisisId, [FromQuery] TipoExportacion tipo)
        {
            var result = await _service.ExportarResultadoAsync(resultadoAnalisisId, tipo);
            if (!result.IsSuccess) return BadRequest(result.Message);
            return Ok(result);
        }
    }
}