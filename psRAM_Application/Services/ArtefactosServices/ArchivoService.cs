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
    public class ArchivoService : IArchivoService
    {
        public Task<OperationResult<IEnumerable<ArchivoDtos>>> ObtenerPorResultadoAnalisis(int resultadoAnalisisId)
        {
            throw new NotImplementedException();
        }
    }
}
