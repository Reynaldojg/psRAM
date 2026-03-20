using psRAM_Application.DTOS.BaseDTOS;
using psRAM_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.AnalisisDTOS
{
    public class ImagenMemoriaDtos : Dtos
    {
        [JsonPropertyName("ruta")]
        public string? Ruta { get; set; }

        [JsonPropertyName("hash")]
        public string? Hash { get; set; }

        [JsonPropertyName("sistema_operativo")]
        public SistemaOperativo SistemaOperativo { get; set; }

        [JsonPropertyName("tamano_bytes")]
        public long TamañoBytes { get; set; }
    }

}
