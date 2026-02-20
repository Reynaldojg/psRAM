using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using psRAM_Application.DTOS.BaseDTOS;

namespace psRAM_Application.DTOS.ArtefactosDtos
{
    public class ArchivoDtos:Dtos
    {
        public string? Nombre {  get; set; }
        public string? Ruta { get; set; }
        public string? Hash { get; set;}
        public string? Extension { get; set;}
        public int ResultadoAnalisisId {  get; set; }
    }
}
