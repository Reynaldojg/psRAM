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
    public class PuglinEjecutadoConfi : IEntityTypeConfiguration<PluginEjecutado>
    {
        public void Configure(EntityTypeBuilder<PluginEjecutado> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.ResultadoAnalisis)
                .IsRequired();
        }
    }
}
