using Microsoft.AspNetCore.Mvc;
using psRAM_Application.Interfaces.IServices.ISeguridad;
using psRAM_Application.Services.SeguridadServices;

namespace psRAM_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RiskScoreController : ControllerBase
    {
        private readonly IRisKcoreService _service;

        public RiskScoreController(IRisKcoreService service)
        {
            _service = service;
        }

        [HttpGet("calcular/{resultadoAnalisisId}")]
        public async Task<IActionResult> Calcular(int resultadoAnalisisId)
        {
            var result = await _service.CalcularRiskCore(resultadoAnalisisId);
            if (!result.IsSuccess) return BadRequest(result.Message);
            return Ok(result);
        }
    }
}