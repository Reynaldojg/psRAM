using psRAM_Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Seguridad
{
    public class ValidacionExterna : AnalisisBase
    {
        public string Fuente { get; set; } //  VirusTotal, etc.
        public string Resultado { get; set; } 
        public DateTime FechaConsulta { get; set; } 
        public string ArtefactoValidado { get; set; } // IP, hash, etc.
    }
}
