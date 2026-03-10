using psRAM_Domain.Entities.Analisis;
using psRAM_Domain.Entities.Base.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Base
{
    public abstract class AnalisisBase : OperationResult<object>
    {
        public int Id {  get; set; }
        public ResultadoAnalisis ResultadoAnalisis { get; set; }
        public int ResultadoAnalisisId { get; set; }
    }
}
