using Microsoft.Extensions.Logging;
using psRAM_Application.Interfaces.IPersistencia;
using psRAM_Application.Interfaces.IServices.ISeguridad;
using psRAM_Application.DTOS.SeguridadDtos;
using psRAM_Domain.Entities.Base.Operation;
using psRAM_Domain.Entities.Seguridad;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace psRAM_Application.Services.SeguridadServices
{
    public sealed class ValidacionExternaService : IValidacionExternaService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<ValidacionExternaService> _logger;

        public ValidacionExternaService(IApplicationDbContext context, ILogger<ValidacionExternaService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<OperationResult<bool>> RegistrarResultadoAsync(ValidacionExternaDtos dto)
        {
            try
            {
                // Mapear DTO -> Entidad
                var entidad = new ValidacionExterna
                {
                    Id = dto.Id,
                    Fuente = dto.Fuente ?? string.Empty,
                    Resultado = dto.Resultado ?? string.Empty,
                    FechaConsulta = dto.FechaConsulta,
                    ArtefactoValidado = dto.ArtefactoValidado ?? string.Empty
                };

                _context.ValidacionesExternas.Add(entidad);
                await _context.SaveChangesAsync();

                return OperationResult<bool>.Success(true, "Validación registrada correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al registrar validación externa");
                return OperationResult<bool>.Failure("Error interno al registrar validación");
            }
        }

        public async Task<OperationResult<IEnumerable<ValidacionExternaDtos>>> ObtenerPorArtefacto(string artefacto)
        {
            try
            {
                var validaciones = await _context.ValidacionesExternas
                    .Where(v => v.ArtefactoValidado == artefacto)
                    .Select(v => new ValidacionExternaDtos
                    {
                        Id = v.Id,
                        Fuente = v.Fuente,
                        Resultado = v.Resultado,
                        FechaConsulta = v.FechaConsulta,
                        ArtefactoValidado = v.ArtefactoValidado
                    })
                    .ToListAsync();

                return OperationResult<IEnumerable<ValidacionExternaDtos>>.Success(validaciones, "Validaciones obtenidas correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener validaciones externas");
                return OperationResult<IEnumerable<ValidacionExternaDtos>>.Failure("Error interno al obtener validaciones");
            }
        }
    }
}
