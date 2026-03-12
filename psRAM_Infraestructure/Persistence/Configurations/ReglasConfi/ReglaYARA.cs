using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using psRAM_Domain.Entities.Reglas;

namespace psRAM_Infrastructure.Persistence.Configurations.ReglasConfi
{
    public class ReglaYARAConfi : IEntityTypeConfiguration<ReglaYARA>
    {
        public void Configure(EntityTypeBuilder<ReglaYARA> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Nombre)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(r => r.Contenido)
                .IsRequired();

            builder.Property(r => r.Etiquetas)
                .HasMaxLength(200);
        }
    }
}
