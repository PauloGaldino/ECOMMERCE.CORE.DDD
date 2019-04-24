using Domain.Entities.Estoques;
using Domain.Interfaces.IVendas;
using Domain.Interfaces.Services.ISVendas;

namespace Domain.Services.SVendas
{
   public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
