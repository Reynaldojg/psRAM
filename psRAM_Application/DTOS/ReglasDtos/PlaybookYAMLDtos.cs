using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.ReglasDtos
{
    public class PlaybookYAMLDtos : Dtos
    {
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? ContenidoYAML { get; set; }
    }
}
