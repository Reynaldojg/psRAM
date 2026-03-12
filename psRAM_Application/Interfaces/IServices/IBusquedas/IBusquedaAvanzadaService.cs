using psRAM_Application.DTOS.BusquedasDtos;
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Interfaces.IServices.IBusquedas
{
    public interface IBusquedaAvanzadaService
    {
        Task<OperationResult<int>> EjecutarBusquedaAsync(BusquedaAvanzadaDtos dto);
        Task<OperationResult<BusquedaAvanzadaDtos>> ObtenerPorId(int id);
    }

}
