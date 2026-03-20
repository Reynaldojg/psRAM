    using psRAM_Application.DTOS.BaseDTOS;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

    namespace psRAM_Application.DTOS.SeguridadDtos
    {
    public class ValidacionExternaDtos : Dtos
    {
        [JsonPropertyName("fuente")]
        public string? Fuente { get; set; }

        [JsonPropertyName("resultado")]
        public string? Resultado { get; set; }

        [JsonPropertyName("fecha_consulta")]
        public DateTime FechaConsulta { get; set; }

        [JsonPropertyName("artefacto_validado")]
        public string? ArtefactoValidado { get; set; }
    }
}
