using psRAM_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Analisis
{
    public class ImagenMemoria
    {
        public int Id { get; set; }
        public string Ruta { get; set; }
        public string Hash { get; set; }
        public SistemaOperativo SistemaOperativo { get; set; }
        public long TamanoBytes { get; set; }
    }
}
