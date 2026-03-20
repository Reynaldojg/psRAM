using psRAM_Application.DTOS.BaseDTOS;
using System.Text.Json.Serialization;

public class PlaybookYAMLDtos : Dtos
{
    [JsonPropertyName("nombre")]
    public string? Nombre { get; set; }

    [JsonPropertyName("descripcion")]
    public string? Descripcion { get; set; }

    [JsonPropertyName("contenido_yaml")]
    public string? ContenidoYAML { get; set; }
}
