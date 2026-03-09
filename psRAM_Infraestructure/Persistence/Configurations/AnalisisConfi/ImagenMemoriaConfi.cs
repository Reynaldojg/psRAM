using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using psRAM_Domain.Entities.Analisis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Infraestructure.Persistence.Configurations.AnalisisConfi
{
    public class ImagenMemoriaConfi : IEntityTypeConfiguration<ImagenMemoria>
    {
        public void Configure(EntityTypeBuilder<ImagenMemoria> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Ruta)
                .IsRequired();

            builder.Property(i => i.Hash)
                .HasMaxLength(256);
        }
    }
}
