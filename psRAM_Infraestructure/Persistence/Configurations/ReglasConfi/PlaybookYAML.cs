using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using psRAM_Domain.Entities.Reglas;

namespace psRAM_Infrastructure.Persistence.Configurations.ReglasConfi
{
    public class PlaybookYAMLConfi : IEntityTypeConfiguration<PlaybookYAML>
    {
        public void Configure(EntityTypeBuilder<PlaybookYAML> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Descripcion)
                .HasMaxLength(500);

            builder.Property(p => p.ContenidoYAML)
                .IsRequired();
        }
    }
}
