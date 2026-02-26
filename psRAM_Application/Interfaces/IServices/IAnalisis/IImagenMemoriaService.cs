using psRAM_Application.DTOS.AnalisisDTOS;
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Interfaces.IServices.IAnalisis
{
    public interface IImagenMemoriaService
    {
        Task<OperationResult<int>> RegistrarImagenAsync(ImagenMemoriaDtos dto);
        Task<OperationResult<ImagenMemoriaDtos>> ObtenerPorIdAsync(int id);

    }
}
