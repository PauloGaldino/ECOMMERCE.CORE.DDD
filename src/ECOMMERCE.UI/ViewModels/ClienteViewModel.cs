using Domain.Entities.Pessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ECOMMERCE.UI.ViewModels
{
    public class ClienteViewModel
    {

        //Chave estrangeria
        [Display(Name = "Codigo da Pessoa")]
        public int PessoaId { get; set; }

        //Propriedade de navegação
        public Pessoa Pessoa { get; set; }
        [Display(Name = "Codigo do Cliente")]
        public int ClienteId { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }



    }
}
