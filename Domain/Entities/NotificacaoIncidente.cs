namespace Domain.Entities
{
    public class NotificacaoIncidente
    {
        public int NotificacaoIncidenteId { get; set; }

        public string Descricao { get; set; }

        public int SetorId { get; set; }

        public int PacienteId { get; set; }

        public string NomePaciente { get; set; }

        public virtual Setor Setores { get; set; }

        public virtual Paciente Pacientes { get; set; }
    }
}
