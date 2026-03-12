using psRAM_Application.DTOS.ReglasDtos;
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Interfaces.IServices.IReglas
{
    public interface IReglaYARAService
    {
        Task<OperationResult<int>> CrearReglaAsync(ReglaYARADtos dto);
        Task<OperationResult<IEnumerable<ReglaYARADtos>>> ObtenerTodasAsync();
    }

}
