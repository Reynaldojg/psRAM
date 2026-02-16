using psRAM_Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Artefactos
{
    public class ConexionRed : AnalisisBase 
    { 
        public string IpOrigen { get; set; } 
        public string IpDestino { get; set; } 
        public int PuertoOrigen { get; set; } 
        public int PuertoDestino { get; set; } 
        public string Protocolo { get; set; } }
}
