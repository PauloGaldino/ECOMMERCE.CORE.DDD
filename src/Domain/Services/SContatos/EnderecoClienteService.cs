using Domain.Entities.Contatos;
using Domain.Interfaces.Repositories.IRContatos;
using Domain.Interfaces.Services.ISContatos;

namespace Domain.Services.SContatos
{
    public class EnderecoClienteService : ServiceBase<EnderecoCliente>, IEnderecoClienteService
    {
        private readonly IEnderecoClienteRepository _enderecoClienteRepository;
        public EnderecoClienteService(IEnderecoClienteRepository enderecoClienteRepository) :base(enderecoClienteRepository)
        {
            _enderecoClienteRepository = enderecoClienteRepository;
        }
    }
}
