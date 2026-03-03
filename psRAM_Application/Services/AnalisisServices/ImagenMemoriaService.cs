using psRAM_Application.DTOS.AnalisisDTOS;
using psRAM_Application.Interfaces.IServices.IAnalisis;
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Services.AnalisisServices
{
    public class ImagenMemoriaService : IImagenMemoriaService
    {
        public Task<OperationResult<ImagenMemoriaDtos>> ObtenerPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<int>> RegistrarImagenAsync(ImagenMemoriaDtos dto)
        {
            throw new NotImplementedException();
        }
    }
}
