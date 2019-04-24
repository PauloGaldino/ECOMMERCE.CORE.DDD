using System.Collections.Generic;
using Application.Interfaces.IAppContatos;
using Domain.Entities.Contatos;
using Domain.Interfaces.Repositories.IRContatos;

namespace Application.Aplications.AppContatos
{
    public class AppEnderecoCliente : IAppEnderecoCliente
    {
        IEnderecoClienteRepository _IEnderecoCliente;
        public AppEnderecoCliente(IEnderecoClienteRepository IEnderecoCliente)
        {
            _IEnderecoCliente = IEnderecoCliente;
        }

        public void Adicionar(EnderecoCliente Objeto)
        {
            _IEnderecoCliente.Adicionar(Objeto);
        }
        public void Atualizar(EnderecoCliente Objeto)
        {
            _IEnderecoCliente.Atualizar(Objeto);
        }

        public void Excluir(EnderecoCliente Objeto)
        {
            _IEnderecoCliente.Excluir(Objeto);
        }

        public IList<EnderecoCliente> Listar()
        {
            return _IEnderecoCliente.Listar();
        }

        public EnderecoCliente ObterPorId(int Id)
        {
            return _IEnderecoCliente.ObterPorId(Id);
        }
    }
}
