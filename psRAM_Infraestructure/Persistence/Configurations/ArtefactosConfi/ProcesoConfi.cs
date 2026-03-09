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
    public class ProcesoConfi : IEntityTypeConfiguration<Proceso>
    {
        public void Configure(EntityTypeBuilder<Proceso> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Pid).IsRequired();
        }
    }
}
