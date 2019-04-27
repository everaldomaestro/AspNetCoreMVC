using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.EntityMap
{
    public class SetorMap : IEntityTypeConfiguration<Setor>
    {
        public void Configure(EntityTypeBuilder<Setor> builder)
        {
            builder.ToTable("Setor");
            builder.HasKey(x => x.SetorId);
            builder.Property(x => x.SetorId).HasColumnName("SetorId");
            builder.Property(x => x.Nome).HasColumnName("Nome");

            builder.HasMany(x => x.NotificacoesIncidentes);
        }
    }
}
