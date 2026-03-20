using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.ArtefactosDtos
{
    public class ProcesoDtos : Dtos
    {
        public int Pid { get; set; }
        public string? Nombre { get; set; }
        public string? Usuario { get; set; }
        public int? ParentPid { get; set; }
        public int ResultadoAnalisisId { get; set; }

        // 🔹 Agregar hashes para mapear el JSON
        public string? HashMD5 { get; set; }
        public string? HashSHA1 { get; set; }
        public string? HashSHA256 { get; set; }

    }

}
