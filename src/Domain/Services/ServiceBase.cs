using System;
using System.Collections.Generic;
using Domain.Interfaces.IPessoas;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.IRPessoas.IProfissoes;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class ServiceBase<T> : IDisposable, IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }



        public void Adicionar(T Objeto)
        {
            _repository.Adicionar(Objeto);
        }

        public T ObterPorId(int Id)
        {
            return _repository.ObterPorId(Id);
        }


        public void Atualizar(T Objeto)
        {
            _repository.Atualizar(Objeto);
        }


        public void Excluir(T Objeto)
        {
            _repository.Excluir(Objeto);
        }
        public IEnumerable<T> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public IList<T> Listar()
        {
            return _repository.Listar();
        }

        public void Dispose()
        {
          _repository.Dispose();
        }


    }
}
