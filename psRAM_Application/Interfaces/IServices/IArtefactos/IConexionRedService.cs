using psRAM_Application.DTOS.ArtefactosDtos;
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Interfaces.IServices.IArtefactos
{
    public interface IConexionRedService
    {
        Task<OperationResult<IEnumerable<ConexionRedDtos>>> ObtenerPorResultadoAnalisis(int resultadoAnalisisId);
    }

}
