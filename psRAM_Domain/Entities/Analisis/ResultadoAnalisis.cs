using psRAM_Domain.Entities.Artefactos;
using psRAM_Domain.Entities.Seguridad;
using psRAM_Domain.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Analisis
{
    public class ResultadoAnalisis
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public SistemaOperativo SistemaOperativo { get; set; }
        public string HashImagen { get; set; }
        public ICollection Procesos { get; set; }
        public ICollection Archivos { get; set; }
        public ICollection Conexiones { get; set; }
        public ICollection Modulos { get; set; }
        public ICollection PluginsEjecutados { get; set; }
        public RiskScore RiskScore { get; set; }
    }
}
