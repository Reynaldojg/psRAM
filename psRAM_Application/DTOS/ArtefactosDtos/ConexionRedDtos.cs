using psRAM_Application.DTOS.BaseDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.DTOS.ArtefactosDtos
{
    public class ConexionRedDtos : Dtos
    {
        public string? IpOrigen { get; set; }
        public string? IpDestino { get; set; }
        public int PuertoOrigen { get; set; }
        public int PuertoDestino { get; set; }
        public string? Protocolo { get; set; }
    }
}
