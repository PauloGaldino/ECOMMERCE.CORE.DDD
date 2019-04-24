using System.Collections.Generic;
using Application.Interfaces;
using Application.Interfaces.IAppPessoas;
using Domain.Entities.Pessoas;
using Domain.Interfaces.IPessoas;

namespace Application.Aplications.AppPessoas
{
    public class AppPessoaTipo : IAppPessoaTipo
    {
        IPessoaTipoRepository _IPessoaTipo;
        public AppPessoaTipo(IPessoaTipoRepository IPessoaTipo)
        {
            _IPessoaTipo = IPessoaTipo;

        }

        public void Adicionar(PessoaTipo Objeto)
        {
            _IPessoaTipo.Adicionar(Objeto);
        }

        public void Atualizar(PessoaTipo Objeto)
        {
            _IPessoaTipo.Atualizar(Objeto);
        }

        public void Excluir(PessoaTipo Objeto)
        {
            _IPessoaTipo.Excluir(Objeto);
        }

        IList<PessoaTipo> IAppServiceBase<PessoaTipo>.Listar()
        {
            return _IPessoaTipo.Listar();
        }

        PessoaTipo IAppServiceBase<PessoaTipo>.ObterPorId(int Id)
        {
            return _IPessoaTipo.ObterPorId(Id);
        }
    }
}
