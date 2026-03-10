using Microsoft.Extensions.Logging;
using psRAM_Application.DTOS.AnalisisDTOS;
using psRAM_Application.Interfaces.IServices.IAnalisis;
using psRAM_Application.Interfaces.IPersistencia;
using psRAM_Domain.Entities.Analisis;
using psRAM_Domain.Entities.Base.Operation;
using System.Threading.Tasks;

namespace psRAM_Application.Services.AnalisisServices
{
    public sealed class ImagenMemoriaService : IImagenMemoriaService
    {
        private readonly IApplicationDbContext _context;
        private readonly ILogger<ImagenMemoriaService> _logger;

        public ImagenMemoriaService(IApplicationDbContext context, ILogger<ImagenMemoriaService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<OperationResult<int>> RegistrarImagenAsync(ImagenMemoriaDtos dto)
        {
            try
            {
                if (dto == null)
                    return OperationResult<int>.Failure("El DTO no puede ser nulo");

                var entidad = new ImagenMemoria
                {
                    Ruta = dto.Ruta,
                    Hash = dto.Hash,
                    SistemaOperativo = dto.SistemaOperativo,
                    TamanoBytes = dto.TamañoBytes
                };

                _context.ImagenesMemoria.Add(entidad);
                await _context.SaveChangesAsync();

                return OperationResult<int>.Success(entidad.Id, "Imagen registrada correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al registrar imagen");
                return OperationResult<int>.Failure("Error interno al registrar imagen");
            }
        }

        public async Task<OperationResult<ImagenMemoriaDtos>> ObtenerPorIdAsync(int id)
        {
            try
            {
                var entidad = await _context.ImagenesMemoria.FindAsync(id);
                if (entidad == null)
                    return OperationResult<ImagenMemoriaDtos>.Failure("No se encontró la imagen");

                var dto = new ImagenMemoriaDtos
                {
                    Id = entidad.Id,
                    Ruta = entidad.Ruta,
                    Hash = entidad.Hash,
                    SistemaOperativo = entidad.SistemaOperativo,
                    TamañoBytes = entidad.TamanoBytes
                };

                return OperationResult<ImagenMemoriaDtos>.Success(dto, "Imagen obtenida correctamente");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener imagen");
                return OperationResult<ImagenMemoriaDtos>.Failure("Error interno al obtener imagen");
            }
        }
    }
}
