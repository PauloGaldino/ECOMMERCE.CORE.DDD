using Domain.Entities.Contatos;
using Domain.Interfaces.Repositories.IRContatos;
using Domain.Interfaces.Services.ISContatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.SContatos
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        public EnderecoService(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
    }
}
