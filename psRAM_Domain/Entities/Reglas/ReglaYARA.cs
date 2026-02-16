using psRAM_Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Reglas
{
    public class ReglaYARA : AnalisisBase 
    { 
        public string Nombre { get; set; } 
        public string Contenido { get; set; } 
        public string Etiquetas { get; set; } 
    }
}
