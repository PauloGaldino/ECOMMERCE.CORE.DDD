using Domain.Entities.Pessoas.Profissoes;
using Domain.Interfaces.Repositories.IRPessoas.IProfissoes;
using Domain.Interfaces.Services.ISPessoas.ISProfissoes;

namespace Domain.Services.SPessoas.SProfissoes
{
    public class ProfissaoService :ServiceBase<Profissao>, IProfissaoService
    {
        private readonly IProfissaoRepository _profissaoRepository;
        public ProfissaoService(IProfissaoRepository profissaoRepository) : base(profissaoRepository)
        {
            _profissaoRepository = profissaoRepository;
        }
    }
}
