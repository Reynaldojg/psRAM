using psRAM_Application.DTOS.AnalisisDTOS;
using psRAM_Application.DTOS.ArtefactosDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_View.Entidades_Auxiliar
{
    public class Resultados
    {
        public List<ProcesoDtos> Procesos { get; set; }
        public List<ArchivoDtos> Archivos { get; set; }
        public List<ConexionRedDtos> Conexiones { get; set; }
        public List<ModuloMaliciosoDtos> Modulos { get; set; }
        public List<PuglinEjecutadoDtos> Plugins { get; set; }
    }

}
