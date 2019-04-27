using System.Collections.Generic;

namespace Domain.Entities
{
    public class Paciente
    {
        public int PacienteId { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<NotificacaoIncidente> NotificacoesIncidentes { get; set; }

    }
}
