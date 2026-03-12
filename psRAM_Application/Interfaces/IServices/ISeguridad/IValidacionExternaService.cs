using psRAM_Application.DTOS.SeguridadDtos;
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Interfaces.IServices.ISeguridad
{
    public interface IValidacionExternaService
    {
        Task<OperationResult<bool>> RegistrarResultadoAsync(ValidacionExternaDtos dto);
        Task<OperationResult<IEnumerable<ValidacionExternaDtos>>> ObtenerPorArtefacto(string artefacto);
    }

}
