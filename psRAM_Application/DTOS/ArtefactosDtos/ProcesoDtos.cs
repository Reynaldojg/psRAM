using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using psRAM_Application.DTOS.BaseDTOS;

namespace psRAM_Application.DTOS.ArtefactosDtos
{
    public class ProcesoDtos:Dtos
    {
        public int Pid {  get; set; }
        public string? Nombre {  get; set; }
        public string? Usuario {  get; set; }
        public int? ParentPid { get; set; }
        public int ResultadoAnalisisId {  get; set; }

    }
}
