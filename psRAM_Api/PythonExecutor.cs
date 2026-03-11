using System.Diagnostics;

namespace psRAM_Api
{
    public class PythonExecutor
    {
        // Ruta de Python dentro de tu entorno virtual
        private readonly string _pythonPath = @"C:\Users\Asus\Downloads\Volatility_IQ\.venv\Scripts\python.exe";

        // Ruta del script principal de tu proyecto
        private readonly string _scriptPath = @"C:\Users\Asus\Downloads\Volatility_IQ\Voliq-Analys\main.py";

        public string EjecutarScript(string argumentos)
        {
            var psi = new ProcessStartInfo
            {
                FileName = _pythonPath,
                Arguments = $"\"{_scriptPath}\" cli {argumentos}", // comillas para rutas con espacios
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new Process { StartInfo = psi })
            {
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                return string.IsNullOrWhiteSpace(error) ? output : $"Error: {error}";
            }
        }
    }
}        
    

