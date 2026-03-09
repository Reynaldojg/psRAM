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
    public class ExportacionConfi : IEntityTypeConfiguration<Exportacion>
    {
        public void Configure(EntityTypeBuilder<Exportacion> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Tipo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Fecha)
                .IsRequired();
        }
    }
}
