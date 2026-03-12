using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using psRAM_Domain.Entities.Seguridad;

namespace psRAM_Infrastructure.Persistence.Configurations.SeguridadConfi
{
    public class ValidacionExternaConfi : IEntityTypeConfiguration<ValidacionExterna>
    {
        public void Configure(EntityTypeBuilder<ValidacionExterna> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Fuente)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(v => v.Resultado)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(v => v.ArtefactoValidado)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(v => v.FechaConsulta)
                .IsRequired();
        }
    }
}
