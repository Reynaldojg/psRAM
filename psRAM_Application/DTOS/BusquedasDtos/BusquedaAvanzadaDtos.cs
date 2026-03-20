using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.BusquedasDtos
{
    public class BusquedaAvanzadaDtos : Dtos
    {
        [JsonPropertyName("filtros_aplicados")]
        public string? FiltrosAplicados { get; set; }

        [JsonPropertyName("fecha_busqueda")]
        public DateTime FechaBusqueda { get; set; }

        [JsonPropertyName("resultados_json")]
        public string? ResultadosJson { get; set; }
    }

}
