using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityMap
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("Paciente");

            builder.HasKey(x => x.PacienteId);

            builder.Property(x => x.PacienteId).HasColumnName("PacienteId");
            builder.Property(x => x.Nome).HasColumnName("Nome");

            builder.HasMany(x => x.NotificacoesIncidentes);
        }
    }
}
