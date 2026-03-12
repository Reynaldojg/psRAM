using Microsoft.Extensions.Logging;
using psRAM_Application.Interfaces.IPersistencia;
using psRAM_Application.Interfaces.IServices.IBusquedas;
using psRAM_Application.DTOS.BusquedasDtos;
using psRAM_Domain.Entities.Base.Operation;
using psRAM_Domain.Entities.Busquedas;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace psRAM_Application.Services.BusquedasServices
{
    public sealed class BusquedaAvanzadaService : IBusquedaAvanzadaService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<BusquedaAvanzadaService> _logger;

        public BusquedaAvanzadaService(IApplicationDbContext context, ILogger<BusquedaAvanzadaService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<OperationResult<int>> EjecutarBusquedaAsync(BusquedaAvanzadaDtos dto)
        {
            try
            {
                // Mapear DTO -> Entidad
                var entidad = new BusquedaAvanzada
                {
                    Id = dto.Id,
                    FiltrosAplicados = dto.FiltrosAplicados ?? string.Empty,
                    FechaBusqueda = dto.FechaBusqueda,
                    ResultadosJson = dto.ResultadosJson ?? string.Empty
                };

                _context.BusquedasAvanzadas.Add(entidad);
                await _context.SaveChangesAsync();

                return OperationResult<int>.Success(entidad.Id, "Búsqueda avanzada registrada correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al ejecutar búsqueda avanzada");
                return OperationResult<int>.Failure("Error interno al ejecutar búsqueda");
            }
        }

        public async Task<OperationResult<BusquedaAvanzadaDtos>> ObtenerPorId(int id)
        {
            try
            {
                var busqueda = await _context.BusquedasAvanzadas.FindAsync(id);
                if (busqueda == null)
                    return OperationResult<BusquedaAvanzadaDtos>.Failure("No se encontró la búsqueda solicitada");

                // Mapear Entidad -> DTO
                var dto = new BusquedaAvanzadaDtos
                {
                    Id = busqueda.Id,
                    FiltrosAplicados = busqueda.FiltrosAplicados,
                    FechaBusqueda = busqueda.FechaBusqueda,
                    ResultadosJson = busqueda.ResultadosJson
                };

                return OperationResult<BusquedaAvanzadaDtos>.Success(dto, "Búsqueda obtenida correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener búsqueda avanzada");
                return OperationResult<BusquedaAvanzadaDtos>.Failure("Error interno al obtener búsqueda");
            }
        }
    }
}
