using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_View.Entidades_Auxiliar
{
    public class AnalisisResponse
    {
        public Resultados Resultados { get; set; }
        public Dictionary<string, List<string>> Iocs { get; set; }
        public Dictionary<string, List<string>> YaraReport { get; set; }
        public int RiesgoGlobal { get; set; }
        public Dictionary<string, CategoriaRiesgo> DesgloseRiesgo { get; set; }
    }

}
