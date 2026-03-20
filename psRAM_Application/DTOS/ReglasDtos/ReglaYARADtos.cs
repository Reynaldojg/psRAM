using psRAM_Application.DTOS.BaseDTOS;
using System.Text.Json.Serialization;

public class ReglaYARADtos : Dtos
{
    [JsonPropertyName("nombre")]
    public string? Nombre { get; set; }

    [JsonPropertyName("contenido")]
    public string? Contenido { get; set; }

    [JsonPropertyName("etiquetas")]
    public string? Etiquetas { get; set; }
}
