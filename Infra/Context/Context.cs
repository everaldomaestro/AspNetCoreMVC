using Domain.Entities;
using Infra.EntityMap;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context
{
    public class NotiLigaContext : DbContext
    {
        public NotiLigaContext(DbContextOptions<NotiLigaContext> options) : base(options)
        {
        }

        public virtual DbSet<Paciente> Pacientes { get; set; }
        public virtual DbSet<Setor> Setores { get; set; }
        public virtual DbSet<NotificacaoIncidente> NotificacoesIncidentes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PacienteMap());
            modelBuilder.ApplyConfiguration(new SetorMap());
            modelBuilder.ApplyConfiguration(new NotificacaoIncidenteMap());
        }
    }
}
