using Domain.Entities.Pessoas;
using Domain.Interfaces.Repositories.IRPessoas;

namespace Infra.Data.Repositories.RPessoas
{
    public  class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
    }
}
