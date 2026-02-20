using psRAM_Application.DTOS.BaseDTOS;
using psRAM_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.AnalisisDTOS
{
    public class ImagenMemoriaDtos: Dtos
    {
        public string? Ruta { get; set; }
        public string? Hash { get; set; }
        public SistemaOperativo SistemaOperativo { get; set; }
        public long TamañoBytes {  get; set; }
    }
}
