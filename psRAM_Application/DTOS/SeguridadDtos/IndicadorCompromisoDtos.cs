using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.SeguridadDtos
{
    public class IndicadorCompromisoDtos : Dtos
    {
        public string? Tipo { get; set; }
        public string? Valor { get; set; }
        public string? Fuente { get; set; }
        public DateTime FechaDeteccion { get; set; }
    }
}
