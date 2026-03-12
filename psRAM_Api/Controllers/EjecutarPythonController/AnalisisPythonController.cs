using Microsoft.AspNetCore.Mvc;

namespace psRAM_Api.Controllers.EjecutarPythonController
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnalisisPythonController : ControllerBase
    {
        private readonly PythonExecutor _executor;

        public AnalisisPythonController(PythonExecutor executor)
        {
            _executor = executor;
        }

        [HttpGet("ejecutar")]
        public IActionResult Ejecutar([FromQuery] string argumentos)
        {
            var resultado = _executor.EjecutarScript(argumentos);
            return Ok(new { parametro = argumentos, salidaPython = resultado });
        }
    }
}