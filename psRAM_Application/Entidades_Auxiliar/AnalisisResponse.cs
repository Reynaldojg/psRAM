using psRAM_Application.DTOS.ArtefactosDtos;
using System;
using System.Collections.Generic;

namespace psRAM_View.Entidades_Auxiliar
{
    public class AnalisisResponse
    {
        // Campos que coinciden exactamente con el JSON de la API
        public string? Fecha { get; set; }
        public string? SistemaOperativo { get; set; }
        public string? HashImagen { get; set; }
        public List<ProcesoDtos>? Procesos { get; set; }
        public List<ConexionRedDtos>? Conexiones { get; set; }
        public List<ModuloMaliciosoDtos>?  Modulos { get; set; }
        public int RiskScore { get; set; }
        public Dictionary<string, CategoriaRiesgo>? DesgloseRiesgo { get; set; }
        public Dictionary<string, List<string>>? IoCs { get; set; }
        public Dictionary<string, List<string>>? YaraReport { get; set; }

        // Propiedad de conveniencia para compatibilidad con código existente
        public ResultadosWrapper? Resultados { get; set; }
    }

    // Clase wrapper para mantener compatibilidad con código que espera Resultados
    public class ResultadosWrapper
    {
        public List<ProcesoDtos>? Procesos { get; set; }
        public List<ConexionRedDtos>? Conexiones { get; set; }
        public List<ModuloMaliciosoDtos>? Modulos { get; set; }
        public List<object>? Archivos { get; set; }
        public List<object>? Plugins { get; set; }
    }

    public class CategoriaRiesgo
    {
        public int Valor { get; set; }
        public string? Nivel { get; set; }
    }
}

