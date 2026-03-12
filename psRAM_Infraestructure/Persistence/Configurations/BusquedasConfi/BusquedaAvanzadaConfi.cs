using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using psRAM_Domain.Entities.Busquedas;

namespace psRAM_Infrastructure.Persistence.Configurations.BusquedasConfi
{
    public class BusquedaAvanzadaConfi : IEntityTypeConfiguration<BusquedaAvanzada>
    {
        public void Configure(EntityTypeBuilder<BusquedaAvanzada> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.FiltrosAplicados)
                .HasMaxLength(500);

            builder.Property(b => b.FechaBusqueda)
                .IsRequired();

            builder.Property(b => b.ResultadosJson)
                .IsRequired();
        }
    }
}
