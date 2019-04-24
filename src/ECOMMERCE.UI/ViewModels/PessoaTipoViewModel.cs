using Domain.Entities.Pessoas;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECOMMERCE.UI.ViewModels
{
    public class PessoaTipoViewModel
    {
        [Key]
        public int PessoaTipoId { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public ICollection<Pessoa> Pessoas { get; set; }
    }
}
