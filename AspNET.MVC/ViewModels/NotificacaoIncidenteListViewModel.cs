using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNET.MVC.ViewModels
{
    public class NotificacaoIncidenteListViewModel
    {
        //Properties Notificacao
        [Key]
        [ScaffoldColumn(false)]
        public int NotificacaoIncidenteId { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Paciente")]
        public string NomePaciente { get; set; }

        [DisplayName("Setor")]
        public string NomeSetor { get; set; }
    }
}
