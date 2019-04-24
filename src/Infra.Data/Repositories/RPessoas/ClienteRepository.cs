using Domain.Entities.Pessoas;
using Domain.Interfaces.IPessoas;
using Domain.Interfaces.Repositories.IRPessoas;

namespace Infra.Data.Repositories.RPessoas
{
   public  class ClienteRepository : RepositoryBase<Cliente>,IClienteRepository
    {
    }
}
