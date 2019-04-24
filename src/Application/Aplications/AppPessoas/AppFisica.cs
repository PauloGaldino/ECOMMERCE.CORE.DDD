using System.Collections.Generic;
using Application.Interfaces.IAppPessoas;
using Domain.Entities.Pessoas;
using Domain.Interfaces.IPessoas;
using Domain.Interfaces.Repositories.IRPessoas;

namespace Application.Aplications.AppPessoas
{
    public class AppFisica : IAppFisicaService
    {
        IFisicaRepository _IFisica;
        public AppFisica(IFisicaRepository IFisica)
        {
            _IFisica = IFisica;
        }

        public void Adicionar(Fisica Objeto)
        {
            _IFisica.Adicionar(Objeto);
        }

        public void Atualizar(Fisica Objeto)
        {
            _IFisica.Atualizar(Objeto);
        }

        public void Excluir(Fisica Objeto)
        {
            _IFisica.Excluir(Objeto);
        }

        public IList<Fisica> Listar()
        {
           return _IFisica.Listar();
        }

        public Fisica ObterPorId(int Id)
        {
            return _IFisica.ObterPorId(Id);
        }
    }
}
