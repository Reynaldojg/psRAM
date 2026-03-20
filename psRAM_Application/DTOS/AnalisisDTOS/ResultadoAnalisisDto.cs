using psRAM_Application.DTOS.ArtefactosDtos;
using psRAM_Application.DTOS.BaseDTOS;
using psRAM_Application.DTOS.SeguridadDtos;
using psRAM_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.AnalisisDTOS
{
    public class ResultadoAnalisisDto : Dtos
    {
        [JsonPropertyName("fecha")]
        public DateTime Fecha { get; set; }

        [JsonPropertyName("sistema_operativo")]
        public SistemaOperativo SistemaOperativo { get; set; }

        [JsonPropertyName("hash_imagen")]
        public string? HashImagen { get; set; }

        [JsonPropertyName("procesos")]
        public List<ProcesoDtos>? Procesos { get; set; }

        [JsonPropertyName("archivos")]
        public List<ArchivoDtos>? Archivos { get; set; }

        [JsonPropertyName("conexiones")]
        public List<ConexionRedDtos>? Conexiones { get; set; }

        [JsonPropertyName("modulos")]
        public List<ModuloMaliciosoDtos>? Modulos { get; set; }

        [JsonPropertyName("plugins_ejecutados")]
        public List<PuglinEjecutadoDtos>? PluginsEjecutados { get; set; }

        [JsonPropertyName("risk_score")]
        public RiskScoreDtos? RiskScore { get; set; }

        [JsonPropertyName("desglose_riesgo")]
        public List<DesgloseRiesgoDto>? DesgloseRiesgo { get; set; }
    }

}
