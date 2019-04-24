using Domain.Entities.Pessoas.Profissoes;
using Domain.Interfaces.Repositories.IRPessoas.IProfissoes;
using Domain.Interfaces.Services.ISPessoas.ISProfissoes;

namespace Domain.Services.SPessoas.SProfissoes
{
    public class ProfissaoPessoaService : ServiceBase<ProfissaoPessoa>, IProfissaoPessoaService
    {
        private readonly IProfissaoPessoaRepository _profissaoPessoaRepository;
        public ProfissaoPessoaService(IProfissaoPessoaRepository profissaoPessoaRepository) :base(profissaoPessoaRepository)
        {
            _profissaoPessoaRepository = profissaoPessoaRepository;
        }
    }
}
