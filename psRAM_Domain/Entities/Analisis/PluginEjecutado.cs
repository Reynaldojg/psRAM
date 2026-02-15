using psRAM_Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Analisis
{
    public class PluginEjecutado :AnalisisBase
    {
        public string Nombre { get; set; }
        public DateTime FechaEjecucion { get; set; }
        public string Duracion { get; set; }

    }
}
