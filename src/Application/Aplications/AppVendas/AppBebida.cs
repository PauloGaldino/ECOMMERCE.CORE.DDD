using System.Collections.Generic;
using Application.Interfaces.IAppVendas;
using Domain.Entities.Vendas;
using Domain.Interfaces.Repositories.IRVendas;

namespace Application.Aplications.AppVendas
{
    public class AppBebida : IAppBebida
    {
        IBebidaRepository _IBebida;
        public AppBebida(IBebidaRepository IBebida)
        {
            _IBebida = IBebida;
        }

        public void Adicionar(Bebida Objeto)
        {
            _IBebida.Adicionar(Objeto);
        }

        public void Atualizar(Bebida Objeto)
        {
            _IBebida.Atualizar(Objeto);
        }

        public void Excluir(Bebida Objeto)
        {
            _IBebida.Excluir(Objeto);
        }

        public IList<Bebida> Listar()
        {
            return _IBebida.Listar();
        }

        public Bebida ObterPorId(int Id)
        {
            return _IBebida.ObterPorId(Id);
        }
    }
}
