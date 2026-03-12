using Microsoft.Extensions.Logging;
using psRAM_Application.Interfaces.IPersistencia;
using psRAM_Application.Interfaces.IServices.ISeguridad;
using psRAM_Application.DTOS.SeguridadDtos;
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace psRAM_Application.Services.SeguridadServices
{
    public sealed class IndicadorCompromisoService : IIndicadorCompromisoService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<IndicadorCompromisoService> _logger;

        public IndicadorCompromisoService(IApplicationDbContext context, ILogger<IndicadorCompromisoService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<OperationResult<IEnumerable<IndicadorCompromisoDtos>>> ObtenerPorFecha(DateTime desde, DateTime hasta)
        {
            try
            {
                var indicadores = await _context.IndicadoresCompromiso
                    .Where(i => i.FechaDeteccion >= desde && i.FechaDeteccion <= hasta)
                    .Select(i => new IndicadorCompromisoDtos
                    {
                        Id = i.Id,
                        // Aquí mapeamos las propiedades de la entidad a las del DTO
                        Tipo = i.Nombre,          // ejemplo: usas Nombre como Tipo
                        Valor = i.Hash,           // ejemplo: usas Hash como Valor
                        Fuente = i.FirmaDigital,  // ejemplo: usas FirmaDigital como Fuente
                        FechaDeteccion = i.FechaDeteccion
                    })
                    .ToListAsync();

                return OperationResult<IEnumerable<IndicadorCompromisoDtos>>.Success(indicadores, "Indicadores obtenidos correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener indicadores de compromiso");
                return OperationResult<IEnumerable<IndicadorCompromisoDtos>>.Failure("Error interno al obtener indicadores");
            }
        }
    }
}
