using System.Collections.Generic;
using APPLICATION.interfaces.IAppVendas;
using Domain.Entities.Estoques;
using Domain.Interfaces.IVendas;

namespace APPLICATION.Application
{
    public class AppProduto : IAppProdutoService
    {
        IProdutoRepository _IProduto;
        public AppProduto(IProdutoRepository IProduto)
        {
            _IProduto = IProduto;
        }

        public void Adcionar(Produto Objeto)
        {
            _IProduto.Adicionar(Objeto);
        }

        public void Adicionar(Produto Objeto)
        {
            _IProduto.Adicionar(Objeto);
        }

        public void Atualizar(Produto Objeto)
        {
            _IProduto.Atualizar(Objeto);
        }

        public void Excluir(Produto Objeto)
        {
            _IProduto.Excluir(Objeto);
        }

        public IList<Produto> Listar()
        {
            return _IProduto.Listar();
        }

        public Produto ObterPorId(int Id)
        {
          return  _IProduto.ObterPorId(Id);
        }
    }
}
