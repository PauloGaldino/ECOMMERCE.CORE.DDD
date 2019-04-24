using Domain.Entities.Pessoas;
using Domain.Interfaces.Repositories.IRPessoas;
using Domain.Interfaces.Services.ISPessoas;

namespace Domain.Services.SPessoas
{
   public  class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
    }
}
