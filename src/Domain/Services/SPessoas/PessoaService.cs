using Domain.Entities.Pessoas;
using Domain.Interfaces.Repositories.IRPessoas;
using Domain.Interfaces.Services.ISPessoas;

namespace Domain.Services.SPessoas
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaService(IPessoaRepository pessoaRepository) : base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
    }
}
