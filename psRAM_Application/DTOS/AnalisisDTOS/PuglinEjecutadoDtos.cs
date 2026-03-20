using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.AnalisisDTOS
{

    public class PuglinEjecutadoDtos : Dtos
    {
        [JsonPropertyName("nombre")]
        public string? Nombre { get; set; }

        [JsonPropertyName("fecha_ejecucion")]
        public DateTime FechaEjecucion { get; set; }

        [JsonPropertyName("duracion")]
        public string? Duracion { get; set; }
    }

}
