using Domain.Entities.Pessoas;
using Domain.Interfaces.Repositories.IRPessoas;
using Domain.Interfaces.Services.ISPessoas;

namespace Domain.Services.SPessoas
{
    public class JuridicaService : ServiceBase<Juridica>, IJuridicaService
    {
        private readonly IJuridicaRepository _juridicaRepository;
        public JuridicaService(IJuridicaRepository juridicaRepository) : base(juridicaRepository)
        {
            _juridicaRepository = juridicaRepository;
        }
    }
}
