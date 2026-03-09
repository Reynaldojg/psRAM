using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using psRAM_Domain.Entities.Artefactos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Infraestructure.Persistence.Configurations.ArtefactosConfi
{
    public class ArchivoConfi : IEntityTypeConfiguration<Archivo>
    {
        public void Configure(EntityTypeBuilder<Archivo> builder)
        {
           builder.HasKey(x => x.Id);

            builder.Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(x => x.Ruta)
                .IsRequired();

        }
    }
}
