using psRAM_Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Seguridad
{
    public class IndicadorCompromiso : AnalisisBase
    {
        public string Nombre { get; set; }
        public string Ruta { get; set; }
        public string Hash { get; set; }
        public string FirmaDigital { get; set; }
    }
}
