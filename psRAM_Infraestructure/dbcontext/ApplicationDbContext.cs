using Microsoft.EntityFrameworkCore;
using psRAM_Application.Interfaces.IPersistencia;
using psRAM_Domain.Entities.Analisis;
using psRAM_Domain.Entities.Artefactos;
using psRAM_Domain.Entities.Busquedas;
using psRAM_Domain.Entities.Reglas;
using psRAM_Domain.Entities.Seguridad;


namespace psRAM_Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<ResultadoAnalisis> ResultadosAnalisis { get; set; }
        public DbSet<Proceso> Procesos { get; set; }
        public DbSet<Archivo> Archivos { get; set; }
        public DbSet<RiskScore> RiskScores { get; set; }
        public DbSet<PluginEjecutado> PluginsEjecutados { get; set; }
        public DbSet<ImagenMemoria> ImagenesMemoria { get; set; }
        public DbSet<Exportacion> Exportaciones { get; set; }

        public DbSet<ConexionRed> ConexionesRed { get; set; }
        public DbSet<ModuloMalicioso> ModulosMaliciosos { get; set; }
        public DbSet<IndicadorCompromiso> IndicadoresCompromiso { get; set; }
        public DbSet<ReglaYARA> ReglasYARA { get; set; }
        public DbSet<PlaybookYAML> PlaybooksYAML { get; set; }
        public DbSet<ValidacionExterna> ValidacionesExternas { get; set; }
        public DbSet<BusquedaAvanzada> BusquedasAvanzadas { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
