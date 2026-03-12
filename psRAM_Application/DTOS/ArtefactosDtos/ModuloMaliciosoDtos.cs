using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.ArtefactosDtos
{
    public class ModuloMaliciosoDtos : Dtos
    {
        public string? Nombre { get; set; }
        public string? Ruta { get; set; }
        public string? Hash { get; set; }
        public string? FirmaDigital { get; set; }
    }
}
