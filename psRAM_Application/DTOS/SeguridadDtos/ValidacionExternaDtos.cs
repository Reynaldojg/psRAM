using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.SeguridadDtos
{
    public class ValidacionExternaDtos : Dtos
    {
        public string? Fuente { get; set; }
        public string? Resultado { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string? ArtefactoValidado { get; set; }
    }
}
