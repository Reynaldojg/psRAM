using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using psRAM_Domain.Entities.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psRAM_Infraestructure.Persistence.Configurations.SeguridadConfi
{
    public class RiskScoreConfi :IEntityTypeConfiguration<RiskScore>
    {
        public void Configure(EntityTypeBuilder<RiskScore> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Valor)
                .IsRequired();

            builder.Property(x=> x.Nivel).HasMaxLength(50);
        }
    }
}
