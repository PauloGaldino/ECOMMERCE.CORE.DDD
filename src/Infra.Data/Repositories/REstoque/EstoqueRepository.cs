using Domain.Entities.Estoques;
using Domain.Interfaces.Services.ISEstoque;

namespace Infra.Data.Repositories.REstoque
{
    public class EstoqueRepository : RepositoryBase<Estoque>, IEstoqueService
    {
    }
}
