using psRAM_View.Entidades_Auxiliar;

public interface IPythonAnalisisService
{
    Task<AnalisisResponse?> AnalizarMemoriaAsync(string filePath);
    AnalisisResponse? AnalizarDesdeArchivo(string filePath);
}
