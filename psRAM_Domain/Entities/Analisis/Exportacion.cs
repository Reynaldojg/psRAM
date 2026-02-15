using psRAM_Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Analisis
{
    public class Exportacion : AnalisisBase
    {
        public string Tipo { get; set; } // CSV, TXT, HTML
        public DateTime Fecha { get; set; }
        public string RutaArchivo { get; set; }


    }
}
