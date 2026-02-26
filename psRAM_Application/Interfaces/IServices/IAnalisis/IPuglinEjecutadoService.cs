using psRAM_Application.DTOS.AnalisisDTOS;
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Interfaces.IServices.IAnalisis
{
    public interface IPuglinEjecutadoService
    {
        Task<OperationResult<bool>> EjecutarPuglinAsync(string nombrePlugin, int resultadoAnalisisId);
        Task<OperationResult<IEnumerable<PuglinEjecutadoDtos>>> ObtenerPorResultadoAnalisis(int resultadoAnalisisId);


    }
}
