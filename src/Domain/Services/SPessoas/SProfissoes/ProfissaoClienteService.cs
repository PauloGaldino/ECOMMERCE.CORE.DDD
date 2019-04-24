
using Domain.Entities.Pessoas.Profissoes;
using Domain.Interfaces.Repositories.IRPessoas.IProfissoes;
using Domain.Interfaces.Services.ISPessoas.ISProfissoes;

namespace Domain.Services.SPessoas.SProfissoes
{
    public class ProfissaoClienteService : ServiceBase<ProfissaoCliente>, IProfissaoClienteService
    {
        private readonly IProfissaoClienteRepository _profissaoClienteRepository;
        public ProfissaoClienteService(IProfissaoClienteRepository profissaoClienteRepository) 
            : base(profissaoClienteRepository)
        {
            _profissaoClienteRepository = profissaoClienteRepository;
        }
    }
}
