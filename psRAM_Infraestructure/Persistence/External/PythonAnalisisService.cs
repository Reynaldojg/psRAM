
using psRAM_Application.Interfaces.IServices.IAnalisis;
using psRAM_View.Entidades_Auxiliar;
using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class PythonAnalisisService : IPythonAnalisisService
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonOptions;

    public PythonAnalisisService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("http://127.0.0.1:8000/");

        // Configuración para que los enums se lean como strings y fechas ISO
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() }
        };
    }

    // Método que llama a la API Python
    public async Task<AnalisisResponse?> AnalizarMemoriaAsync(string filePath)
    {
        try
        {
            using var form = new MultipartFormDataContent();
            form.Add(new StreamContent(File.OpenRead(filePath)), "file", Path.GetFileName(filePath));

            var response = await _httpClient.PostAsync("analizar", form);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Error en la API Python: {response.StatusCode}");
                return null;
            }

            var json = await response.Content.ReadAsStringAsync();

            Console.WriteLine("JSON recibido de Python:");
            Console.WriteLine(json);

            var resultado = JsonSerializer.Deserialize<AnalisisResponse>(json, _jsonOptions);

            if (resultado == null)
            {
                Console.WriteLine("⚠️ No se pudo deserializar el JSON en AnalisisResponse.");
            }

            return resultado;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error al analizar memoria: {ex.Message}");
            return null;
        }
    }

    // Método auxiliar para probar con un archivo .txt
    public AnalisisResponse? AnalizarDesdeArchivo(string filePath)
    {
        try
        {
            var json = File.ReadAllText(filePath);

            Console.WriteLine("JSON cargado desde archivo:");
            Console.WriteLine(json);

            var resultado = JsonSerializer.Deserialize<AnalisisResponse>(json, _jsonOptions);

            if (resultado == null)
            {
                Console.WriteLine("⚠️ No se pudo deserializar el JSON.");
            }

            return resultado;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error al leer archivo: {ex.Message}");
            return null;
        }
    }
}