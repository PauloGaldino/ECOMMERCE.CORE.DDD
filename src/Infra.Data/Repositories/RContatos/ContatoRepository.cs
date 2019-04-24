using Domain.Entities.Contatos;
using Domain.Interfaces.Repositories.IRContatos;

namespace Infra.Data.Repositories.RContatos
{
    public class ContatoRepository : RepositoryBase<Contato>, IContatoRepository
    {
    }
}
