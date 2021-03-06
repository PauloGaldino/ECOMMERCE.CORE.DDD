﻿using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        void Adicionar(T Objeto);
        T ObterPorId(int Id);

        IEnumerable<T> ObterTodos();

        void Atualizar(T Objeto);

        void Excluir(T Objeto);

        IList<T> Listar();

        void Dispose();
    }
}