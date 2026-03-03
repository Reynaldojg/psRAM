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
    public class PuglinEjecutadoService : IPuglinEjecutadoService
    {
        public Task<OperationResult<bool>> EjecutarPuglinAsync(string nombrePlugin, int resultadoAnalisisId)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<IEnumerable<PuglinEjecutadoDtos>>> ObtenerPorResultadoAnalisis(int resultadoAnalisisId)
        {
            throw new NotImplementedException();
        }
    }
}
