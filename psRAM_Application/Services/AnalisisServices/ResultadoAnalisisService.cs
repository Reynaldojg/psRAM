using Microsoft.Extensions.Logging;
using psRAM_Application.DTOS.AnalisisDTOS;
using psRAM_Application.Interfaces.IPersistencia;
using psRAM_Application.Interfaces.IServices.IAnalisis;
using psRAM_Domain.Entities.Analisis;
using psRAM_Domain.Entities.Base.Operation;

namespace psRAM_Application.Services.AnalisisServices
{
    public sealed class ResultadoAnalisisService : IResultadoAnalisisService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<ResultadoAnalisisService> _logger;

        public ResultadoAnalisisService(IApplicationDbContext context, ILogger<ResultadoAnalisisService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<OperationResult<int>> CrearAsync(ResultadoAnalisisDto dto)
        {
            try
            {
                if (dto == null)
                    return OperationResult<int>.Failure("El DTO no puede ser nulo");

                var entidad = new ResultadoAnalisis
                {
                    HashImagen = dto.HashImagen,
                    SistemaOperativo = dto.SistemaOperativo,
                    Fecha = DateTime.Now
                };

                _context.ResultadosAnalisis.Add(entidad);
                await _context.SaveChangesAsync();

                return OperationResult<int>.Success(entidad.Id, "Resultado creado correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear resultado");
                return OperationResult<int>.Failure("Error interno al crear resultado");
            }
        }

        public async Task<OperationResult<ResultadoAnalisisDto>> ObtenerPorIdAsync(int id)
        {
            try
            {
                var entidad = await _context.ResultadosAnalisis.FindAsync(id);
                if (entidad == null)
                    return OperationResult<ResultadoAnalisisDto>.Failure("No se encontró el resultado");

                var dto = new ResultadoAnalisisDto
                {
                    Id = entidad.Id,
                    HashImagen = entidad.HashImagen,
                    SistemaOperativo = entidad.SistemaOperativo,
                    Fecha = entidad.Fecha
                };

                return OperationResult<ResultadoAnalisisDto>.Success(dto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener resultado");
                return OperationResult<ResultadoAnalisisDto>.Failure("Error interno al obtener resultado");
            }
        }

        public Task<OperationResult<IEnumerable<ResultadoAnalisisDto>>> ObtenerTodosAsync()
        {
            try
            {
                var lista = _context.ResultadosAnalisis
                    .Select(r => new ResultadoAnalisisDto
                    {
                        Id = r.Id,
                        HashImagen = r.HashImagen,
                        SistemaOperativo = r.SistemaOperativo,
                        Fecha = r.Fecha
                    }).ToList();

                return Task.FromResult(OperationResult<IEnumerable<ResultadoAnalisisDto>>.Success(lista));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener todos los resultados");
                return Task.FromResult(OperationResult<IEnumerable<ResultadoAnalisisDto>>.Failure("Error interno al obtener resultados"));
            }
        }
    }
}
