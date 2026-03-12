using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.BusquedasDtos
{
    public class BusquedaAvanzadaDtos : Dtos
    {
        public string? FiltrosAplicados { get; set; }
        public DateTime FechaBusqueda { get; set; }
        public string? ResultadosJson { get; set; }
    }
}
