using Microsoft.AspNetCore.Mvc;
using psRAM_Application.Interfaces.IServices.IAnalisis;

namespace psRAM_Api.Controllers.EjecutarPythonApiController
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnalisisController : ControllerBase
    {
        private readonly IPythonAnalisisService _pythonService;

        public AnalisisController(IPythonAnalisisService pythonService)
        {
            _pythonService = pythonService;
        }

        [HttpPost("analizar")]
        public async Task<IActionResult> Analizar(IFormFile file)
        {
            var path = Path.GetTempFileName();
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var resultado = await _pythonService.AnalizarMemoriaAsync(path);
            return Ok(resultado);
        }
    }
}
