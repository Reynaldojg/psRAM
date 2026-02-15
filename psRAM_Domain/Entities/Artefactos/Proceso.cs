using psRAM_Domain.Entities.Analisis;
using psRAM_Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Artefactos
{
    public class Proceso : AnalisisBase
    {
        public int Pid { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public int? ParentPid { get; set; }
    }
}
