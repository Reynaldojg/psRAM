using System.Diagnostics;

namespace psRAM_Api
{
    public class PythonExecutor
    {
        private readonly string _pythonPath = @"C:\Users\Asus\Downloads\Volatility_IQ\.venv\Scripts\python.exe";
        private readonly string _cliScriptPath = @"C:\Users\Asus\Downloads\Volatility_IQ\Voliq-Analys\cli.py";

        public string EjecutarScript(string argumentos)
        {
            var psi = new ProcessStartInfo
            {
                FileName = _pythonPath,
                Arguments = $"\"{_cliScriptPath}\" {argumentos}", // ejecuta cli.py con los argumentos
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
