using psRAM_Application.DTOS.SeguridadDtos;
using psRAM_Application.Interfaces.IServices.ISeguridad;
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Services.SeguridadServices
{
    public class RiskScoreService : IRisKcoreService
    {
        public Task<OperationResult<RiskScoreDtos>> CalcularRiskCore(int resultadoAnalisisId)
        {
            throw new NotImplementedException();
        }
    }
}
