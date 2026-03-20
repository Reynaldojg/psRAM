
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Interfaces.IServices.IReglas
{
    public interface IPlaybookYAMLService
    {
        Task<OperationResult<int>> CrearPlaybookAsync(PlaybookYAMLDtos dto);
        Task<OperationResult<IEnumerable<PlaybookYAMLDtos>>> ObtenerTodosAsync();
    }

}
