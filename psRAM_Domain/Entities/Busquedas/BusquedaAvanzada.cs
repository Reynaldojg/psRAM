using psRAM_Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Busquedas
{
    public class BusquedaAvanzada : AnalisisBase 
    { 
        public string FiltrosAplicados { get; set; } 
        public DateTime FechaBusqueda { get; set; } 
        public string ResultadosJson { get; set; } 
    }
}
