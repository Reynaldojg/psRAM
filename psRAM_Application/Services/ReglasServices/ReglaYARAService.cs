using Microsoft.Extensions.Logging;
using psRAM_Application.Interfaces.IPersistencia;
using psRAM_Application.Interfaces.IServices.IReglas;
using psRAM_Application.DTOS.ReglasDtos;
using psRAM_Domain.Entities.Base.Operation;
using psRAM_Domain.Entities.Reglas;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace psRAM_Application.Services.ReglasServices
{
    public sealed class ReglaYARAService : IReglaYARAService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<ReglaYARAService> _logger;

        public ReglaYARAService(IApplicationDbContext context, ILogger<ReglaYARAService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<OperationResult<int>> CrearReglaAsync(ReglaYARADtos dto)
        {
            try
            {
                // Mapear DTO -> Entidad
                var entidad = new ReglaYARA
                {
                    Id = dto.Id,
                    Nombre = dto.Nombre ?? string.Empty,
                    Contenido = dto.Contenido ?? string.Empty,
                    Etiquetas = dto.Etiquetas ?? string.Empty
                };

                _context.ReglasYARA.Add(entidad);
                await _context.SaveChangesAsync();

                return OperationResult<int>.Success(entidad.Id, "Regla YARA creada correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear regla YARA");
                return OperationResult<int>.Failure("Error interno al crear regla");
            }
        }

        public async Task<OperationResult<IEnumerable<ReglaYARADtos>>> ObtenerTodasAsync()
        {
            try
            {
                // Mapear Entidad -> DTO
                var reglas = await _context.ReglasYARA
                    .Select(r => new ReglaYARADtos
                    {
                        Id = r.Id,
                        Nombre = r.Nombre,
                        Contenido = r.Contenido,
                        Etiquetas = r.Etiquetas
                    })
                    .ToListAsync();

                return OperationResult<IEnumerable<ReglaYARADtos>>.Success(reglas, "Reglas YARA obtenidas correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener reglas YARA");
                return OperationResult<IEnumerable<ReglaYARADtos>>.Failure("Error interno al obtener reglas");
            }
        }
    }
}
