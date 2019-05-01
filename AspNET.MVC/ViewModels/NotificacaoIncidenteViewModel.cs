using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNET.MVC.ViewModels
{
    public class NotificacaoIncidenteViewModel
    {
        [Key]
        public int NotificacaoIncidenteId { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public int SetorId { get; set; }

        public int PacienteId { get; set; }

        [Display(Name = "Paciente")]
        public string NomePaciente { get; set; }

        [Display(Name = "Setor")]
        public string NomeSetor { get; set; }
    }
}
