using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using psRAM_Domain.Entities.Seguridad;

namespace psRAM_Infrastructure.Persistence.Configurations.SeguridadConfi
{
    public class IndicadorCompromisoConfi : IEntityTypeConfiguration<IndicadorCompromiso>
    {
        public void Configure(EntityTypeBuilder<IndicadorCompromiso> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Nombre)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(i => i.Ruta)
                .HasMaxLength(500);

            builder.Property(i => i.Hash)
                .HasMaxLength(128);

            builder.Property(i => i.FirmaDigital)
                .HasMaxLength(256);

            builder.Property(i => i.FechaDeteccion)
                .IsRequired();
        }
    }
}
