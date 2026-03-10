using Microsoft.Extensions.Logging;
using psRAM_Application.DTOS.AnalisisDTOS;
using psRAM_Application.Interfaces.IPersistencia;
using psRAM_Application.Interfaces.IServices.IAnalisis;
using psRAM_Domain.Entities.Analisis;
using psRAM_Domain.Entities.Base.Operation;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace psRAM_Application.Services.AnalisisServices
{
    public sealed class PuglinEjecutadoService : IPuglinEjecutadoService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<PuglinEjecutadoService> _logger;

        public PuglinEjecutadoService(IApplicationDbContext context, ILogger<PuglinEjecutadoService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<OperationResult<bool>> EjecutarPuglinAsync(string nombrePlugin, int resultadoAnalisisId)
        {
            try
            {
                var resultado = await _context.ResultadosAnalisis.FindAsync(resultadoAnalisisId);
                if (resultado == null)
                    return OperationResult<bool>.Failure("No se encontró el resultado de análisis");

                var plugin = new PluginEjecutado
                {
                    Nombre = nombrePlugin,
                    FechaEjecucion = DateTime.Now,
                    Duracion = "5s", // aquí puedes calcular la duración real si lo necesitas
                    ResultadoAnalisisId = resultado.Id
                };

                _context.PluginsEjecutados.Add(plugin);
                await _context.SaveChangesAsync();

                return OperationResult<bool>.Success(true, "Plugin ejecutado correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al ejecutar plugin");
                return OperationResult<bool>.Failure("Error interno al ejecutar plugin");
            }
        }

        public Task<OperationResult<IEnumerable<PuglinEjecutadoDtos>>> ObtenerPorResultadoAnalisis(int resultadoAnalisisId)
        {
            try
            {
                var lista = _context.PluginsEjecutados
                    .Where(p => p.ResultadoAnalisisId == resultadoAnalisisId)
                    .Select(p => new PuglinEjecutadoDtos
                    {
                        Id = p.Id,
                        Nombre = p.Nombre,
                        FechaEjecucion = p.FechaEjecucion,
                        Duracion = p.Duracion
                    }).ToList();

                return Task.FromResult(OperationResult<IEnumerable<PuglinEjecutadoDtos>>.Success(lista));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener plugins ejecutados");
                return Task.FromResult(OperationResult<IEnumerable<PuglinEjecutadoDtos>>.Failure("Error interno al obtener plugins"));
            }
        }
    }
}
