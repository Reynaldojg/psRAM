using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using psRAM_Application.DTOS.BaseDTOS;
using psRAM_Domain.Enums;

namespace psRAM_Application.DTOS.SeguridadDtos
{
    public class RiskScoreDtos
    {
        public int Valor {  get; set; }
        public NivelRiesgo Nivel {  get; set; }
        public string? Justifiacion { get; set; }
        public int ResultadoAnalisisId {  get; set; }
    }
}
