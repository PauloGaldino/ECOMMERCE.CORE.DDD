using Domain.Interfaces.Repositories;
using Infra.Data.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Data.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T>  where T : class
    {
        protected DbContextGeral Db = new DbContextGeral();

        public void Adicionar(T Objeto)
        {
           Db.Set<T>().Add(Objeto);
            Db.SaveChanges();
        }

        public void Atualizar(T Objeto)
        {
            Db.Entry(Objeto).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Dispose()
        {
           Db.Dispose();
        }

        public void Excluir(T Objeto)
        {
           Db.Set<T>().Remove(Objeto);
            Db.SaveChanges();
        }
    

        public IList<T> Listar()
        {
            return Db.Set<T>().ToList() ;
        }

        public T ObterPorId(int Id)
        {
        return Db.Set<T>().Find(Id);
        }

        public IEnumerable<T> ObterTodos()
        {
            return Db.Set<T>().ToList();
        }
    }
}
