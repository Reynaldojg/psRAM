using Microsoft.Extensions.Logging;
using psRAM_Application.DTOS.SeguridadDtos;
using psRAM_Application.Interfaces.IServices.ISeguridad;
using psRAM_Application.Interfaces.IPersistencia;
using psRAM_Domain.Entities.Base.Operation;
using System.Threading.Tasks;
using psRAM_Domain.Enums; // Asegúrate de importar el namespace correcto para el enum

namespace psRAM_Application.Services.SeguridadServices
{
    public sealed class RiskScoreService : IRisKcoreService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<RiskScoreService> _logger;

        public RiskScoreService(IApplicationDbContext context, ILogger<RiskScoreService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<OperationResult<RiskScoreDtos>> CalcularRiskCore(int resultadoAnalisisId)
        {
            try
            {
                var resultado = await _context.ResultadosAnalisis.FindAsync(resultadoAnalisisId);
                if (resultado == null)
                    return OperationResult<RiskScoreDtos>.Failure("No se encontró el resultado de análisis");

                // Simulación de cálculo
                var dto = new RiskScoreDtos
                {
                    ResultadoAnalisisId = resultado.Id,
                    Valor = 75,
                    Nivel = NivelRiesgo.Medio // Fix: assign the enum value instead of a string
                }; 

                return OperationResult<RiskScoreDtos>.Success(dto, "RiskScore calculado correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al calcular RiskScore");
                return OperationResult<RiskScoreDtos>.Failure("Error interno al calcular RiskScore");
            }
        }
    }
}
