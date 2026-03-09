using Microsoft.EntityFrameworkCore;
using psRAM_Domain.Entities.Analisis;
using psRAM_Domain.Entities.Artefactos;
using psRAM_Domain.Entities.Busquedas;
using psRAM_Domain.Entities.Reglas;
using psRAM_Domain.Entities.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Application.Interfaces.IPersistencia
{
    public interface IApplicationDbContext
    {
        DbSet<ResultadoAnalisis> ResultadosAnalisis { get; set; }
        DbSet<Proceso> Procesos { get; set; }
        DbSet<Archivo> Archivos { get; set; }
        DbSet<RiskScore> RiskScores { get; set; }
        DbSet<PluginEjecutado> PluginsEjecutados { get; set; }
        DbSet<ImagenMemoria> ImagenesMemoria { get; set; }
        DbSet<Exportacion> Exportaciones { get; set; }

        DbSet<ConexionRed> ConexionesRed { get; set; }
        DbSet<ModuloMalicioso> ModulosMaliciosos { get; set; }
        DbSet<IndicadorCompromiso> IndicadoresCompromiso { get; set; }
        DbSet<ReglaYARA> ReglasYARA { get; set; }
        DbSet<PlaybookYAML> PlaybooksYAML { get; set; }
        DbSet<ValidacionExterna> ValidacionesExternas { get; set; }
        DbSet<BusquedaAvanzada> BusquedasAvanzadas { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
