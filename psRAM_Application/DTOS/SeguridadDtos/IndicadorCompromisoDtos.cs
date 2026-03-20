using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.SeguridadDtos
{
    public class IndicadorCompromisoDtos : Dtos
    {
        [JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        [JsonPropertyName("valor")]
        public string? Valor { get; set; }

        [JsonPropertyName("fuente")]
        public string? Fuente { get; set; }

        [JsonPropertyName("fecha_deteccion")]
        public DateTime FechaDeteccion { get; set; }
    }

}
