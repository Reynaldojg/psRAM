using psRAM_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using psRAM_Domain.Entities.Base.Operation;

namespace psRAM_Application.Interfaces.IServices.IAnalisis
{
    public interface IExportacionService
    {
        Task<OperationResult<string>> ExportarResultadoAsync(int resultadoAnalisisId, TipoExportacion tipo);
    }
}
