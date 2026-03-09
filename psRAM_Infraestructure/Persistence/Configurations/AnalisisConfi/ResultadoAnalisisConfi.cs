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
    public class ResultadoAnalisisConfi : IEntityTypeConfiguration<ResultadoAnalisis>
    {
        public void Configure(EntityTypeBuilder<ResultadoAnalisis> builder)
        {
           builder.HasKey(r => r.Id);
           
            builder.Property(r => r.HashImagen)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(r => r.Fecha)
                .IsRequired();

            builder.Property(r => r.SistemaOperativo)
                .HasConversion<string>()
                .IsRequired();
        }
    }
}
