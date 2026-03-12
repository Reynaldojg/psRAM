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
    public sealed class PlaybookYAMLService : IPlaybookYAMLService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<PlaybookYAMLService> _logger;

        public PlaybookYAMLService(IApplicationDbContext context, ILogger<PlaybookYAMLService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<OperationResult<int>> CrearPlaybookAsync(PlaybookYAMLDtos dto)
        {
            try
            {
                var entidad = new PlaybookYAML
                {
                    Id = dto.Id,
                    Nombre = dto.Nombre ?? string.Empty,
                    Descripcion = dto.Descripcion ?? string.Empty,
                    ContenidoYAML = dto.ContenidoYAML ?? string.Empty
                };

                _context.PlaybooksYAML.Add(entidad);
                await _context.SaveChangesAsync();

                return OperationResult<int>.Success(entidad.Id, "Playbook YAML creado correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear playbook YAML");
                return OperationResult<int>.Failure("Error interno al crear playbook");
            }
        }

        public async Task<OperationResult<IEnumerable<PlaybookYAMLDtos>>> ObtenerTodosAsync()
        {
            try
            {
                var playbooks = await _context.PlaybooksYAML
                    .Select(p => new PlaybookYAMLDtos
                    {
                        Id = p.Id,
                        Nombre = p.Nombre,
                        Descripcion = p.Descripcion,
                        ContenidoYAML = p.ContenidoYAML
                    })
                    .ToListAsync();

                return OperationResult<IEnumerable<PlaybookYAMLDtos>>.Success(playbooks, "Playbooks YAML obtenidos correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener playbooks YAML");
                return OperationResult<IEnumerable<PlaybookYAMLDtos>>.Failure("Error interno al obtener playbooks");
            }
        }
    }
}
