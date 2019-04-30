using System.ComponentModel.DataAnnotations;

namespace AspNET.MVC.ViewModels
{
    public class NotificacaoIncidenteViewModel
    {
        //Properties Notificacao
        [Key]
        public int NotificacaoIncidenteId { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Paciente")]
        public string NomePaciente { get; set; }

        [Display(Name = "Setor")]
        public string NomeSetor { get; set; }
    }
}
