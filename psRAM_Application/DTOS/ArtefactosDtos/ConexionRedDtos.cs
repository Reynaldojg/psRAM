using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.ArtefactosDtos
{
    public class ConexionRedDtos : Dtos
    {
        [JsonPropertyName("ip_origen")]
        public string? IpOrigen { get; set; }

        [JsonPropertyName("ip_destino")]
        public string? IpDestino { get; set; }

        [JsonPropertyName("puerto_origen")]
        public int PuertoOrigen { get; set; }

        [JsonPropertyName("puerto_destino")]
        public int PuertoDestino { get; set; }

        [JsonPropertyName("protocolo")]
        public string? Protocolo { get; set; }
    }

}
