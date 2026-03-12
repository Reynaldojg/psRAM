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
    public sealed class ModuloMaliciosoService : IModuloMaliciosoService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<ModuloMaliciosoService> _logger;

        public ModuloMaliciosoService(IApplicationDbContext context, ILogger<ModuloMaliciosoService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<OperationResult<IEnumerable<ModuloMaliciosoDtos>>> ObtenerPorResultadoAnalisis(int resultadoAnalisisId)
        {
            try
            {
                var modulos = _context.ModulosMaliciosos
                    .Where(m => m.ResultadoAnalisisId == resultadoAnalisisId)
                    .ToList();

                return OperationResult<IEnumerable<ModuloMaliciosoDtos>>.Success(modulos, "Módulos obtenidos correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener módulos maliciosos");
                return OperationResult<IEnumerable<ModuloMaliciosoDtos>>.Failure("Error interno al obtener módulos");
            }
        }
    }
}
