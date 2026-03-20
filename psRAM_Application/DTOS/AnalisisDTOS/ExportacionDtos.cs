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
    public class ExportacionDtos : Dtos
    {
        [JsonPropertyName("tipo")]
        public TipoExportacion Tipo { get; set; }

        [JsonPropertyName("fecha")]
        public DateTime Fecha { get; set; }

        [JsonPropertyName("ruta_archivo")]
        public string? RutaArchivo { get; set; }

        [JsonPropertyName("resultado_analisis_id")]
        public int ResultadoAnalisisId { get; set; }
    }

}
