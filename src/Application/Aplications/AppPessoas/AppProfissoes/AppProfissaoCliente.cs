using System.Collections.Generic;
using Application.Interfaces.IAppPessoas.IAppProfissoes;
using Domain.Entities.Pessoas.Profissoes;
using Domain.Interfaces.Services.ISPessoas.ISProfissoes;

namespace Application.Aplications.AppPessoas.AppProfissoes
{
    public class AppProfissaoCliente : IAppProfissaoClienteService
    {
        IProfissaoClienteService _IProfissaoCliente;
        public AppProfissaoCliente(IProfissaoClienteService IProfissaoCliente)
        {
            _IProfissaoCliente = IProfissaoCliente;
        }

        public void Adicionar(ProfissaoCliente Objeto)
        {
            _IProfissaoCliente.Adicionar(Objeto);
        }

        public void Atualizar(ProfissaoCliente Objeto)
        {
            _IProfissaoCliente.Atualizar(Objeto);
        }

        public void Excluir(ProfissaoCliente Objeto)
        {
            _IProfissaoCliente.Excluir(Objeto);
        }

        public IList<ProfissaoCliente> Listar()
        {
            return _IProfissaoCliente.Listar();
        }

        public ProfissaoCliente ObterPorId(int Id)
        {
            return _IProfissaoCliente.ObterPorId(Id);
        }
    }
}
