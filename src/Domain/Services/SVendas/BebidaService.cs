using Domain.Entities.Vendas;
using Domain.Interfaces.Repositories.IRVendas;
using Domain.Interfaces.Services.ISVendas;

namespace Domain.Services.SVendas
{
    public class BebidaService : ServiceBase<Bebida>, IBebidaService
    {
        private readonly IBebidaRepository _bebidaRepository;
        public BebidaService(IBebidaRepository bebidaRepository) : base(bebidaRepository)
        {
            _bebidaRepository = bebidaRepository;
        }
    }
}
