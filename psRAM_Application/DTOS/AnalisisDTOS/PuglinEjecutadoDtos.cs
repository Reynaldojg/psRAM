using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.AnalisisDTOS
{
    public class PuglinEjecutadoDtos : Dtos
    {
        public string? Nombre {  get; set; }
        public DateTime FechaEjecucion {  get; set; }
        public string? Duracion { get; set; }


    }
}
