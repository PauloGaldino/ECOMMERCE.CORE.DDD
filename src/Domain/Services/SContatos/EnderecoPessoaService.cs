using Domain.Entities.Contatos;
using Domain.Interfaces.Repositories.IRContatos;
using Domain.Interfaces.Services.ISContatos;

namespace Domain.Services.SContatos
{
    public class EnderecoPessoaService : ServiceBase<EnderecoPessoa>, IEnderecoPessoaService
    {
        private readonly IEnderecoPessoaRepository _enderecoPessoaRepository;
        public EnderecoPessoaService(IEnderecoPessoaRepository enderecoPessoaRepository) : base(enderecoPessoaRepository)
        {
            _enderecoPessoaRepository = enderecoPessoaRepository;
        }
    }
}
