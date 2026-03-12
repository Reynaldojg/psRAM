using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.ReglasDtos
{
    public class ReglaYARADtos : Dtos
    {
        public string? Nombre { get; set; }
        public string? Contenido { get; set; }
        public string? Etiquetas { get; set; }
    }
}
