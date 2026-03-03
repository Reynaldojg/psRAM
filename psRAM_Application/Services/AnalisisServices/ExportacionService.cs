using psRAM_Application.Interfaces.IServices.IAnalisis;
using psRAM_Domain.Entities.Base.Operation;
using psRAM_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Services.AnalisisServices
{
    public class ExportacionService : IExportacionService
    {
        public Task<OperationResult<string>> ExportarResultadoAsync(int resultadoAnalisisId, TipoExportacion tipo)
        {
            throw new NotImplementedException();
        }
    }
}
