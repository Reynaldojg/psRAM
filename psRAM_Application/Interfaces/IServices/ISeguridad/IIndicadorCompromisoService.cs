using psRAM_Application.DTOS.SeguridadDtos;
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Interfaces.IServices.ISeguridad
{
    public interface IIndicadorCompromisoService
    {
        Task<OperationResult<IEnumerable<IndicadorCompromisoDtos>>> ObtenerPorFecha(DateTime desde, DateTime hasta);
    }

}
