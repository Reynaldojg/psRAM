using Microsoft.Extensions.Logging;
using psRAM_Application.DTOS.ArtefactosDtos;
using psRAM_Application.Interfaces.IPersistencia;
using psRAM_Application.Interfaces.IServices.IArtefactos;
using psRAM_Domain.Entities.Base.Operation;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace psRAM_Application.Services.ArtefactosServices
{
    public sealed class ConexionRedService : IConexionRedService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<ConexionRedService> _logger;

        public ConexionRedService(IApplicationDbContext context, ILogger<ConexionRedService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<OperationResult<IEnumerable<ConexionRedDtos>>> ObtenerPorResultadoAnalisis(int resultadoAnalisisId)
        {
            try
            {
                var conexiones = await Task.Run(() =>
                    _context.ConexionesRed
                        .Where(c => c.ResultadoAnalisisId == resultadoAnalisisId)
                        .Select(c => new ConexionRedDtos
                        {
                            IpOrigen = c.IpOrigen,
                            PuertoOrigen = c.PuertoOrigen,
                            IpDestino = c.IpDestino,
                            PuertoDestino = c.PuertoDestino,
                            Protocolo = c.Protocolo,
                            Pid = 0 // Set this appropriately if available in ConexionRed
                        })
                        .ToList()
                );

                return OperationResult<IEnumerable<ConexionRedDtos>>.Success(conexiones, "Conexiones obtenidas correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener conexiones de red");
                return OperationResult<IEnumerable<ConexionRedDtos>>.Failure("Error interno al obtener conexiones");
            }
        }
    }
}

