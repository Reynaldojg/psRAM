using psRAM_Domain.Entities.Analisis;
using psRAM_Domain.Entities.Base;
using psRAM_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Seguridad
{
    public class RiskScore : AnalisisBase
    {
        public int Valor { get; set; }
        public NivelRiesgo Nivel { get; set; } // Bajo, Medio, Alto 
        public string Justificacion { get; set; }
    }
}
