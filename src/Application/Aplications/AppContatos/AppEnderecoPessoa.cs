using System.Collections.Generic;
using Application.Interfaces.IAppContatos;
using Domain.Entities.Contatos;
using Domain.Interfaces.Repositories.IRContatos;

namespace Application.Aplications.AppContatos
{
    public class AppEnderecoPessoa : IAppEnderecoPessoa
    {
        IEnderecoPessoaRepository _IEnderecoPessoa;
        public AppEnderecoPessoa(IEnderecoPessoaRepository IEnderecoPessoa)
        {
            _IEnderecoPessoa = IEnderecoPessoa; 
        }

        public void Adicionar(EnderecoPessoa Objeto)
        {
            _IEnderecoPessoa.Adicionar(Objeto);
        }

        public void Atualizar(EnderecoPessoa Objeto)
        {
            _IEnderecoPessoa.Atualizar(Objeto);
        }

        public void Excluir(EnderecoPessoa Objeto)
        {
            _IEnderecoPessoa.Excluir(Objeto);
        }

        public IList<EnderecoPessoa> Listar()
        {
            return _IEnderecoPessoa.Listar();
        }

        public EnderecoPessoa ObterPorId(int Id)
        {
            return _IEnderecoPessoa.ObterPorId(Id);
        }
    }
}
