using Application.Interfaces;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Application.Aplications
{
    public  class AppServiceBase<T> : IDisposable, IAppServiceBase<T> where T : class
    {
        private readonly IServiceBase<T> _serviceBase;

        public AppServiceBase(IServiceBase<T> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Adicionar(T Objeto)
        {
            _serviceBase.Adicionar(Objeto);
        }

        public T ObterPorId(int id)
        {
            return _serviceBase.ObterPorId(id);
        }

        public void Atualizar(T Objeto)
        {
            _serviceBase.Atualizar(Objeto);
        }

        public void Excluir(T Objeto)
        {
            _serviceBase.Excluir(Objeto);
        }

        public void Dispose()
        {
           //_serviceBase.Dispose();
        }

        public IList<T> Listar()
        {
          return  _serviceBase.Listar();
        }
    }
}
