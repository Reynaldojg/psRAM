using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.ArtefactosDtos
{
    public class ArchivoDtos : Dtos
    {
        public string? Nombre { get; set; }
        public string? Ruta { get; set; }
        public string? Extension { get; set; }
        public int ResultadoAnalisisId { get; set; }

        // 🔹 Agregar hashes
        public string? HashMD5 { get; set; }
        public string? HashSHA1 { get; set; }
        public string? HashSHA256 { get; set; }
    }
}
