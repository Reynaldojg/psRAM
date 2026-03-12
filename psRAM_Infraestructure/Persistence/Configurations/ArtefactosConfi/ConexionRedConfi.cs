using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using psRAM_Domain.Entities.Artefactos;

namespace psRAM_Infrastructure.Persistence.Configurations.ArtefactosConfi
{
    public class ConexionRedConfi : IEntityTypeConfiguration<ConexionRed>
    {
        public void Configure(EntityTypeBuilder<ConexionRed> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.IpOrigen)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.IpDestino)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.PuertoOrigen)
                .IsRequired();

            builder.Property(c => c.PuertoDestino)
                .IsRequired();

            builder.Property(c => c.Protocolo)
                .HasMaxLength(50);
        }
    }
}
