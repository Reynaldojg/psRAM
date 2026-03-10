using Microsoft.Extensions.Logging;
using psRAM_Application.Interfaces.IPersistencia;
using psRAM_Application.Interfaces.IServices.IAnalisis;
using psRAM_Domain.Entities.Base.Operation;
using psRAM_Domain.Enums;
using System.Threading.Tasks;

namespace psRAM_Application.Services.AnalisisServices
{
    public sealed class ExportacionService : IExportacionService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<ExportacionService> _logger;

        public ExportacionService(IApplicationDbContext context, ILogger<ExportacionService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<OperationResult<string>> ExportarResultadoAsync(int resultadoAnalisisId, TipoExportacion tipo)
        {
            try
            {
                var resultado = await _context.ResultadosAnalisis.FindAsync(resultadoAnalisisId);
                if (resultado == null)
                    return OperationResult<string>.Failure("No se encontró el resultado de análisis");

                // Aquí simulas la exportación según el tipo
                string contenido = $"Exportando resultado {resultado.Id} en formato {tipo}";

                return OperationResult<string>.Success(contenido, "Exportación realizada correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al exportar resultado");
                return OperationResult<string>.Failure("Error interno al exportar resultado");
            }
        }
    }
}