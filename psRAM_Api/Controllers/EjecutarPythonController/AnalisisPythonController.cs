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

        [HttpGet("ejecutar/{param}")]
        public IActionResult Ejecutar(string param)
        {
            var resultado = _executor.EjecutarScript(param);
            return Ok(new { parametro = param, salidaPython = resultado });
        }
    }
}
