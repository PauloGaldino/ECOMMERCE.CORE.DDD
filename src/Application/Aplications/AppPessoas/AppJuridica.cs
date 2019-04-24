using System.Collections.Generic;
using Application.Interfaces.IAppPessoas;
using Domain.Entities.Pessoas;
using Domain.Interfaces.IPessoas;
using Domain.Interfaces.Repositories.IRPessoas;

namespace Application.Aplications.AppPessoas
{
    public class AppJuridica : IAppJuridicaService
    {
        IJuridicaRepository _IJuridica;
        public AppJuridica(IJuridicaRepository IJuridica)
        {
            _IJuridica = IJuridica;
        }

        public void Adicionar(Juridica Objeto)
        {
            _IJuridica.Adicionar(Objeto);
        }

        public void Atualizar(Juridica Objeto)
        {
            _IJuridica.Atualizar(Objeto);
        }

        public void Excluir(Juridica Objeto)
        {
            _IJuridica.Excluir(Objeto);
        }

        public IList<Juridica> Listar()
        {
            return _IJuridica.Listar();
        }

            public Juridica ObterPorId(int Id)
        {
            return _IJuridica.ObterPorId(Id);
        }
    }
}
