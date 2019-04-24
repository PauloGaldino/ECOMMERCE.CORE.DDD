using Domain.Entities.Contatos;
using Domain.Interfaces.Repositories.IRContatos;

namespace Infra.Data.Repositories.RContatos
{
    public class EmailRepository : RepositoryBase<Email>, IEmailRepository
    {
    }
}
