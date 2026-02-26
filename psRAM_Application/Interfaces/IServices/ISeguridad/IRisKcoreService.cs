using psRAM_Application.DTOS.SeguridadDtos;
using psRAM_Domain.Entities.Base.Operation;
using psRAM_Domain.Entities.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Interfaces.IServices.ISeguridad
{
    public interface IRisKcoreService
    {
        Task<OperationResult<RiskScoreDtos>> CalcularRiskCore(int resultadoAnalisisId);
    }
}
