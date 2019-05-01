using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityMap
{
    public class NotificacaoIncidenteMap : IEntityTypeConfiguration<NotificacaoIncidente>
    {
        public void Configure(EntityTypeBuilder<NotificacaoIncidente> builder)
        {
            builder.ToTable("NotificacaoIncidente");

            builder.HasKey(x => x.NotificacaoIncidenteId);

            builder.Property(x => x.NotificacaoIncidenteId).HasColumnName("NotificacaoIncidenteId");
            builder.Property(x => x.Descricao).HasColumnName("Descricao");
            builder.Property(x => x.SetorId).HasColumnName("SetorId");
            builder.Property(x => x.PacienteId).HasColumnName("PacienteId");
            builder.Property(x => x.NomePaciente).HasColumnName("NomePaciente");
        }
    }
}
