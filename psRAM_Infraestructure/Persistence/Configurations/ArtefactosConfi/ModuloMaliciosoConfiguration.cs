using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using psRAM_Domain.Entities.Artefactos;

namespace psRAM_Infrastructure.Persistence.Configurations.ArtefactosConfi
{
    public class ModuloMaliciosoConfi : IEntityTypeConfiguration<ModuloMalicioso>
    {
        public void Configure(EntityTypeBuilder<ModuloMalicioso> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Nombre)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(m => m.Ruta)
                .HasMaxLength(500);

            builder.Property(m => m.Hash)
                .HasMaxLength(128);

            builder.Property(m => m.FirmaDigital)
                .HasMaxLength(256);
        }
    }
}
