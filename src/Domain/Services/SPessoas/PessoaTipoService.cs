using Domain.Entities.Pessoas;
using Domain.Interfaces.IPessoas;
using Domain.Interfaces.Services.ISPessoas;

namespace Domain.Services.SPessoas
{
   public class PessoaTipoService : ServiceBase<PessoaTipo>, IPessoaTipoService
    {
        private readonly IPessoaTipoRepository _pessoaTipoRepository;
        public PessoaTipoService(IPessoaTipoRepository pessoaTipoRepository)
            : base(pessoaTipoRepository)
        {
            _pessoaTipoRepository = pessoaTipoRepository;
        }
    }
}
