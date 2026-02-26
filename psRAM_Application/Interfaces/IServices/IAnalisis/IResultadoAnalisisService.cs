using psRAM_Application.DTOS.AnalisisDTOS;
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Interfaces.IServices.IAnalisis
{
    public interface IResultadoAnalisisService
    {
        Task<OperationResult<int>> CrearAsync(ResultadoAnalisisDto dto);
        Task<OperationResult<ResultadoAnalisisDto>> ObtenerPorIdAsync(int id);
        Task<OperationResult<IEnumerable<ResultadoAnalisisDto>>> ObtenerTodosAsync();

    }
}
