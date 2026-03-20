using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using psRAM_Application.DTOS.AnalisisDTOS;
using psRAM_Application.Interfaces.IServices.IAnalisis;
using psRAM_Application.Services;
using view.Pages.Modulo;

public class DashboardModel : PageModel
{
    private readonly IPythonAnalisisService _pythonService;

    public DashboardViewModel ViewDataModel { get; set; }

    public DashboardModel(IPythonAnalisisService pythonService)
    {
        _pythonService = pythonService;
    }

    public async Task<IActionResult> OnPostAnalizarAsync(string filePath)
    {
        var resultado = await _pythonService.AnalizarMemoriaAsync(filePath);

        ViewDataModel = new DashboardViewModel
        {
            Resultado = resultado,
            Normal = resultado.Procesos.Count(p => p.ResultadoAnalisisId < 5),
            Sospechosos = resultado.Procesos.Count(p => p.ResultadoAnalisisId >= 5 && p.ResultadoAnalisisId < 15),
            Criticos = resultado.Procesos.Count(p => p.ResultadoAnalisisId >= 15)
        };

        return Page();
    }
}
