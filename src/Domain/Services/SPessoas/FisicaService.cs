using Domain.Entities.Pessoas;
using Domain.Interfaces.Repositories.IRPessoas;
using Domain.Interfaces.Services.ISPessoas;

namespace Domain.Services.SPessoas
{
    public class FisicaService : ServiceBase<Fisica>, IFisicaService
    {
        private readonly IFisicaRepository _fisicaRepository;
        public FisicaService(IFisicaRepository fisicaRepository) : base(fisicaRepository)
        {
            _fisicaRepository = fisicaRepository;
        }
    }
}
