using psRAM_Application.DTOS.AnalisisDTOS;

namespace view.Pages.Modulo
{
    public class DashboardViewModel
    {
        public ResultadoAnalisisDto Resultado { get; set; }
        public int Normal { get; set; }
        public int Sospechosos { get; set; }
        public int Criticos { get; set; }
    }
}
