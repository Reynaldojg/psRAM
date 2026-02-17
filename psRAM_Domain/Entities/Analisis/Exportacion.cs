using psRAM_Domain.Entities.Base;
using psRAM_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Domain.Entities.Analisis
{
    public class Exportacion : AnalisisBase
    {
        public TipoExportacion Tipo { get; set; } // CSV, TXT, HTML
        public DateTime Fecha { get; set; }
        public string RutaArchivo { get; set; }


    }
}
