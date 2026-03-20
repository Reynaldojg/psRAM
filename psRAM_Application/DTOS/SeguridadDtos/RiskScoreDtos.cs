using psRAM_Application.DTOS.BaseDTOS;
using psRAM_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.SeguridadDtos
{
    public class RiskScoreDtos
    {
        [JsonPropertyName("valor")]
        public int Valor { get; set; }

        [JsonPropertyName("nivel")]
        public NivelRiesgo Nivel { get; set; }

        [JsonPropertyName("justificacion")]
        public string? Justificacion { get; set; }

        [JsonPropertyName("resultado_analisis_id")]
        public int ResultadoAnalisisId { get; set; }
    }

}
