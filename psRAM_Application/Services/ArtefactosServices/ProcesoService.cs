using Microsoft.Extensions.Logging;
using psRAM_Application.DTOS.ArtefactosDtos;
using psRAM_Application.Interfaces.IPersistencia;
using psRAM_Application.Interfaces.IServices.IArtefactos;
using psRAM_Domain.Entities.Base.Operation;


namespace psRAM_Application.Services.ArtefactosServices
{
    public sealed class ProcesoService : IProcesoService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<ProcesoService> _logger;

        public ProcesoService(IApplicationDbContext context, ILogger<ProcesoService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Task<OperationResult<IEnumerable<ProcesoDtos>>> ObtenerPorResultadoAnalisis(int resultadoAnalisisId)
        {
            try
            {
                var lista = _context.Procesos
                    .Where(p => p.ResultadoAnalisisId == resultadoAnalisisId)
                    .Select(p => new ProcesoDtos
                    {
                        Id = p.Id,
                        Nombre = p.Nombre,
                        Pid = p.Pid
                    }).ToList();

                return Task.FromResult(OperationResult<IEnumerable<ProcesoDtos>>.Success(lista));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener procesos");
                return Task.FromResult(OperationResult<IEnumerable<ProcesoDtos>>.Failure("Error interno al obtener procesos"));
            }
        }
    }
}