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
    public sealed class ArchivoService : IArchivoService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<ArchivoService> _logger;

        public ArchivoService(IApplicationDbContext context, ILogger<ArchivoService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Task<OperationResult<IEnumerable<ArchivoDtos>>> ObtenerPorResultadoAnalisis(int resultadoAnalisisId)
        {
            try
            {
                var lista = _context.Archivos
                    .Where(a => a.ResultadoAnalisisId == resultadoAnalisisId)
                    .Select(a => new ArchivoDtos
                    {
                        Id = a.Id,
                        Nombre = a.Nombre,
                        Ruta = a.Ruta
                    }).ToList();

                return Task.FromResult(OperationResult<IEnumerable<ArchivoDtos>>.Success(lista));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener archivos");
                return Task.FromResult(OperationResult<IEnumerable<ArchivoDtos>>.Failure("Error interno al obtener archivos"));
            }
        }
    }
}
