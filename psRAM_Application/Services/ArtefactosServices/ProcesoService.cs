using psRAM_Application.DTOS.ArtefactosDtos;
using psRAM_Application.Interfaces.IServices.IArtefactos;
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Services.ArtefactosServices
{
    public class ProcesoService : IProcesoService
    {
        public Task<OperationResult<IEnumerable<ProcesoDtos>>> ObtenerPorResultadoAnalisis(int resultadoAnalisisId)
        {
            throw new NotImplementedException();
        }
    }
}
