using System.Collections.Generic;

namespace Domain.Entities
{
    public class Setor
    {
        public int SetorId { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<NotificacaoIncidente> NotificacoesIncidentes { get; set; }
    }
}
