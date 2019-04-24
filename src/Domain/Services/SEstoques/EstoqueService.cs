using Domain.Entities.Estoques;
using Domain.Interfaces.Repositories.IREstoque;
using Domain.Interfaces.Services.ISEstoque;

namespace Domain.Services.SEstoques
{
    public class EstoqueService : ServiceBase<Estoque>, IEstoqueService
    {
        private readonly IEstoqueReoository _estoqueReoository;
        public EstoqueService(IEstoqueReoository estoqueReoository): base(estoqueReoository)
        {
            _estoqueReoository = estoqueReoository;
        }
    }
}
