using System.Collections.Generic;
using Application.Interfaces.IAppPessoas.IAppProfissoes;
using Domain.Entities.Pessoas.Profissoes;
using Domain.Interfaces.Repositories.IRPessoas.IProfissoes;
using Domain.Interfaces.Services.ISPessoas.ISProfissoes;

namespace Application.Aplications.AppPessoas.AppProfissoes
{
    public class AppProfissaoPessoa : IAppProfissaoPessoaService
    {
        IProfissaoPessoaRepository _IProfissaoPessoa;
        public AppProfissaoPessoa(IProfissaoPessoaRepository IProfissaoPessoa)
        {
            _IProfissaoPessoa = IProfissaoPessoa;
        }

        public void Adicionar(ProfissaoPessoa Objeto)
        {
            _IProfissaoPessoa.Adicionar(Objeto);
        }

        public void Atualizar(ProfissaoPessoa Objeto)
        {
            _IProfissaoPessoa.Atualizar(Objeto);
        }

        public void Excluir(ProfissaoPessoa Objeto)
        {
            _IProfissaoPessoa.Excluir(Objeto);
        }

        public IList<ProfissaoPessoa> Listar()
        {
            return _IProfissaoPessoa.Listar();
        }

        public ProfissaoPessoa ObterPorId(int Id)
        {
            return _IProfissaoPessoa.ObterPorId(Id);
        }
    }
}
